PRAGMA foreign_keys = ON;

CREATE TABLE colors (
    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    colorname TEXT NOT NULL
);

CREATE TABLE subjects (
    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    subjectname TEXT NOT NULL
);

CREATE TABLE Tasks (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    subject INTEGER NOT NULL,
    description TEXT,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    due_date DATETIME,
    color INTEGER DEFAULT 1, 
    state INTEGER DEFAULT 1 NOT NULL,
    
    FOREIGN KEY(color) REFERENCES colors(id),
    FOREIGN KEY(subject) REFERENCES subjects(id)
);

INSERT INTO colors (id, colorname) VALUES 
    (1, 'Red'), 

CREATE VIEW v_Tasks AS
SELECT 
    t.id,
    t.name,
    s.subjectname AS subject,
    t.description,
    t.created_at,
    t.due_date,
    col.colorname AS color,
    t.state
FROM Tasks t
LEFT JOIN subjects s ON t.subject = s.id
LEFT JOIN colors col ON t.color = col.id;