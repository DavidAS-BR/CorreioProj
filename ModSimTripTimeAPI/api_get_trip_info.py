import json

from flask import Flask, make_response

from mod_sim_trip_time_api import mod_sim_trip_time_api

app = Flask(__name__)


@app.route("/gettripinfo&de=<cepfrom>&para=<cepto>", methods=['GET'])
def CepTripTime(cepfrom, cepto):
    response = make_response(json.dumps(mod_sim_trip_time_api(cepfrom, cepto)))
    response.headers['content-type'] = 'application/json; charset=UTF-8'

    return response


if __name__ == "__main__":
    app.run(debug=True)
