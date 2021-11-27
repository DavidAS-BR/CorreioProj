import json

from flask import Flask, make_response

from mod_sim_trip_time_api import mod_sim_trip_time_api
from mod_sim_trip_time_api import localizar_cep


app = Flask(__name__)


@app.route("/gettripinfo&de=<cepfrom>&para=<cepto>", methods=['GET'])
def CepTripTime(cepfrom, cepto):
    response = make_response(json.dumps(mod_sim_trip_time_api(cepfrom, cepto), ensure_ascii=False).encode('utf-8'))
    response.headers['content-type'] = 'application/json; charset=utf-8'

    return response


@app.route("/getcepvalidation&cep=<cep>", methods=['GET'])
def CEPValidation(cep):
    response = make_response(json.dumps(localizar_cep(cep), ensure_ascii=False).encode('utf-8'))
    response.headers['content-type'] = 'application/json; charset=utf-8'

    return response


if __name__ == "__main__":
    app.run(debug=True)
