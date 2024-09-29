CREATE TABLE "Customer" (
	"CustomerId"	INTEGER,
	"Name"	TEXT,
	"Email"	TEXT,
	"Phone"	TEXT,
	PRIMARY KEY("CustomerId")
);


CREATE TABLE "Location" (
	"LocationId"	INTEGER,
	"CustomerId"	INTEGER,
	"Address"	TEXT,
	PRIMARY KEY("LocationId")
);


CREATE TABLE "ChangeLog" (
	"ChangeLogId"	INTEGER,
	"TableName"	TEXT,
	"RecordId"	INTEGER,
	"ColumnName"	TEXT,
	"PreviousValue"	TEXT,
	"NewValue"	TEXT,
	"Timestamp"	TEXT,
	PRIMARY KEY("ChangeLogId" AUTOINCREMENT)
);