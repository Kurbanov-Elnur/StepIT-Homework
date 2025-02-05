const bookService = require('../services/bookService');

const createBook = async (req, res) => {
    try {
        const result = await bookService.createBook(req.body);
        res.status(201).json({ message: 'Book created successfully', book: result.book });
    } catch (err) {
        res.status(400).json({ message: err.message });
    }
};

const getBookByName = async (req, res) => {
    try {
        const result = await bookService.getBookByName(req.params.name);
        res.status(200).json({ book: result.book });
    } catch (err) {
        res.status(404).json({ message: err.message });
    }
};

const getBooks = async (req, res) => {
    try {
        const result = await bookService.getBooks();
        res.status(200).json({ books: result.books });
    } catch (err) {
        res.status(400).json({ message: err.message });
    }
};

const updateBook = async (req, res) => {
    try {
        const result = await bookService.updateBookByName(req.params.name, req.body);
        res.status(200).json({ message: 'Book updated successfully', book: result.book });
    } catch (err) {
        res.status(404).json({ message: err.message });
    }
};

const deleteBook = async (req, res) => {
    try {
        const result = await bookService.deleteBookByName(req.params.name);
        res.status(200).json({ message: result.message });
    } catch (err) {
        res.status(404).json({ message: err.message });
    }
};

module.exports = { createBook, getBookByName, getBooks, updateBook, deleteBook };