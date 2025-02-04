const express = require('express');
const { readFile, writeFile } = require('./fileManager');
const app = express();
const PORT = 3000;

app.use(express.text());

app.get('/file', async (req, res) => {
    try {
        const path = require('path');
        const filePath = path.join(__dirname, 'data.txt');

        const data = await readFile(filePath);
        res.status(200).send(data);
    } catch (err) {
        res.status(404).send('File not found');
    }
});

app.post('/file', async (req, res) => {
    try {
        const content = req.body;
        await writeFile('data.txt', content);
        res.status(200).send('File updated successfully');
    } catch (err) {
        res.status(500).send('Error updating file');
    }
});

app.get('/time', (req, res) => {
    const currentTime = new Date().toLocaleTimeString();
    res.status(200).send(currentTime);
});

app.get('/date', (req, res) => {
    const currentDate = new Date().toISOString().split('T')[0];
    res.status(200).send(currentDate);
});

app.listen(PORT, () => {
    console.log(`Server is running at http://localhost:${PORT}`);
});