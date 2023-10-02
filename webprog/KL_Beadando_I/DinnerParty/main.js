'use strict';

const counties = [
    'Bács-Kiskun',
    'Baranya',
    'Békés',
    'Borsod-Abaúj-Zemplén',
    'Budapest',
    'Csongrád',
    'Fejér',
    'Győr-Moson-Sopron',
    'Hajdú-Bihar',
    'Heves',
    'Jász-Nagykun-Szolnok',
    'Komárom-Esztergom',
    'Nógrád',
    'Pest',
    'Somogy',
    'Szabolcs-Szatmár-Bereg',
    'Tolna',
    'Vas',
    'Veszprém',
    'Zala'
];

const countyInput = document.querySelector('#countyInput');

counties.map(county => {
    countyInput.insertAdjacentHTML('beforeend', `<option>${county}</option>`);
});
