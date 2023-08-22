﻿using Educate.Domain.Commons;

namespace Educate.Domain.Entities;

public class Answer : Auditable
{
    public string Text { get; set; } = string.Empty;
    public bool IsTrue { get; set; }

    public long AttachmentId { get; set; }
    public Attachment Attachment { get; set; } = default!;

    public long QuestionId { get; set; }
    public Question Question { get; set; } = default!;
}
