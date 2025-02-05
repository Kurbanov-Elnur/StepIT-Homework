const express = require('express');

const {
    createBook,
    getBookByName,
    getBooks,
    updateBook,
    deleteBook
} = require('../controllers/bookController');

const router = express.Router();

router.post("/create", createBook);
router.get("/:name", getBookByName);
router.get("/", getBooks);
router.put("/:name", updateBook);
router.delete("/:name", deleteBook);

module.exports = router;