const mongoose = require('mongoose');

const BookSchema = new mongoose.Schema(
    {
        Id: { type: String, required: true, unique: true },
        Name: { type: String, required: true, unique: true },
        Author: { type: String, required: true },
        PublicationYear: { type: Number, required: true },
        Genre: { type: String, required: true },
    }
)

module.exports = mongoose.model('Book', BookSchema);