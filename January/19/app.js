const { readFile, writeFile } = require('./fileManager');

writeFile('example.txt', 'Hello, this is a test!')
    .then((message) => {
        console.log(message);

        return readFile('example.txt');
    })
    .then((data) => {
        console.log('File content:', data);
    })
    .catch((err) => {
        console.error(err);
    });