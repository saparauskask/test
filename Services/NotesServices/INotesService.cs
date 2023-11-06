﻿using Microsoft.AspNetCore.Mvc;
using OnlineNotes.Data;
using OnlineNotes.Models;
using OnlineNotes.Models.Enums;
using OnlineNotes.Models.Requests.Note;

namespace OnlineNotes.Services.NotesServices
{
    public interface INotesService
    {
        Task<Note?> GetNoteAsync(int? id);
        Task<bool> CreateNoteAsync(CreateNoteRequest note);
        Task<bool> UpdateNoteAsync(EditNoteRequest note);
        Task<bool> DeleteNoteAsync(DeleteNoteRequest note);
        Task<IEnumerable<Note>?> GetFilteredNotesToListAsync(NoteStatus? filterStatus);
        Task<IEnumerable<Note>?> GetIndexedNotesToListAsync(string term);
        NoteStatus? GetFilterStatus();
        Task<bool> CalculateAvgRating(Note note);
    }
}
