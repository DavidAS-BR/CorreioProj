import json
import re
import time

import requests

from geopy.geocoders import Nominatim


def localizar_cep(cep) -> dict:
    """
    Faz uma consulta do CEP no site dos correios para pegar informações de um CEP.
    Retorna um dicionário com as informações no formato para ser passado para a biblioteca geopy.

    :param cep: CEP do Local
    """

    # Setando os headers necessários
    headers = {'User-Agent': 'Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:93.0) Gecko/20100101 Firefox/93.0',
               'Content-Type': 'application/x-www-form-urlencoded; charset=utf-8'}

    # Definindo o request
    payload = {'endereco': cep, 'tipoCEP': 'ALL'}

    # Fazendo o request
    response = requests.post("https://buscacepinter.correios.com.br/app/endereco/carrega-cep-endereco.php",
                             headers=headers,
                             data=payload)

    # Pegando os dados da response
    endereco = {
        'street': re.sub(r'-(?!.*-).*', '', json.loads(response.text)['dados'][0]['logradouroDNEC']).strip(),  # Removendo tudo depois do último hífen (número de x até y e outras informações não necessárias) para não atraplhar nossa consulta
        'city': json.loads(response.text)['dados'][0]['localidade'],
        'county': re.sub(r'\([^)]*\)', '', json.loads(response.text)['dados'][0]['bairro']).strip() # Removendo conteúdo entre parenteses que indicam a ZONA do bairro
    }

    return endereco


def get_lag_lon(location_data: dict) -> list:
    """
    Retorna uma lista com a latitute e logitude do endereço passado no parametro `location_data`

    :param location_data: Dicionário com os dados para query na biblioteca geopy
    """

    # Configurando um user agent para o nome de um navegador
    geoloc = Nominatim(user_agent="Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:93.0) Gecko/20100101 Firefox/93.0")

    # Peindo para a bilbioteca fazer um query no site e nos retornar as informações do endereço passado
    local = geoloc.geocode(location_data)

    # Retornando uma list[ latitute: float, longitute: float]
    return [local.longitude, local.latitude]


def get_trip_time(de: list, para: list) -> dict:
    """
    Retorna um dicionário com as informações de tempo de viagem de uma localidade até outra, esses dados são pegos
    do site https://www.openstreetmap.org/.

    :param de: Recebe uma lista contendo a latitude e longitute do ponto de partida.
    :param para: Recebe uma lista contendo a latitude e longitute do ponto de destino.
    """

    headers = {'User-Agent': 'Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:93.0) Gecko/20100101 Firefox/93.0'}

    response = requests.get(f'https://routing.openstreetmap.de/routed-car/route/v1/driving/{de[0]},{de[1]};{para[0]},{para[1]}', headers=headers)

    return json.loads(response.text)


def mod_sim_trip_time_api(cep_de, cep_para) -> dict:
    """
    Retorna informações contendo o tempo de um local até o outro.

    :param cep_de: CEP do endereço de partida
    :param cep_para: CEP do endereço de destino
    """

    try:
        endereco_partida = localizar_cep(cep_de)
        endereco_destino = localizar_cep(cep_para)

    except Exception:
        return {'error': 'Este CEP não existe!'}

    try:
        laglon_partida = get_lag_lon(endereco_partida)
        laglon_destino = get_lag_lon(endereco_destino)

    except Exception:
        return {'error': f'Não conseguimos achar as informações necessárias para este endereço!',
                'cep_dest_info': endereco_destino,
                'cep_part_info': endereco_partida}

    info = get_trip_time(laglon_partida, laglon_destino)

    trip_info = {
        "partida": info['waypoints'][0]['name'],
        "destino": info['waypoints'][1]['name'],
        "tempo_de_viagem_seconds": info['routes'][0]['duration'],
        "tempo_de_viagem": time.strftime('%H:%M:%S', time.gmtime(info['routes'][0]['duration']))
    }

    return trip_info
