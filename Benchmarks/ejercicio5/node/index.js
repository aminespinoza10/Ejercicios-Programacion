const https = require('https');

const options = {
    hostname: 'api.api-ninjas.com',
    path: '/v1/etf?ticker=SPY',
    method: 'GET',
    headers: {
        'X-Api-Key': 'kRa7NM9a8mXTcgSoB7hFJBGZNayCZurnZkIqc1Cq'
    }
};

const startTime = Date.now();

const req = https.request(options, (res) => {
    let data = '';

    res.on('data', (chunk) => {
        data += chunk;
    });

    res.on('end', () => {
        const elapsed = (Date.now() - startTime) / 1000;
        
        console.log('Response:');
        try {
            const json = JSON.parse(data);
            console.log(json);
        } catch (e) {
            console.log(data);
        }
        console.log(`\nTime taken: ${elapsed.toFixed(4)} seconds`);
    });
});

req.on('error', (error) => {
    const elapsed = (Date.now() - startTime) / 1000;
    console.error(`Error: ${error.message}`);
    console.log(`\nTime taken: ${elapsed.toFixed(4)} seconds`);
});

req.end();
