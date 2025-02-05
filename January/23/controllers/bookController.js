const bookService = require('../services/bookService');

const createBook = async (req, res) => {
    try {
        await bookService.createBook(
            req.body
        );
        res.status(201).json({ message: 'Success' });
    } catch (err) {
        res.status(400).json({ message: err.message });
    }
};

module.exports = { createBook };