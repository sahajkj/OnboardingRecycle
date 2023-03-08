DROP DATABASE IF EXISTS [waste_disposal];
CREATE DATABASE [waste_disposal]; 
USE [waste_disposal];

SET NAMES utf8 ;

CREATE TABLE [Item] (
  [item_id] int(11) NOT NULL, 
  [name] varchar(50) NOT NULL,
  [method] varchar(512) NOT NULL,
  PRIMARY KEY ([item_id])
) 
INSERT INTO [Item] VALUES (1,'Newspapers','Dry and unsoiled newspapers should be placed loose in your recycling bin. Soiled newspapers must be placed in the general waste bin.');
INSERT INTO [Item] VALUES (2,'Paper bags','Clean, dry and unsoiled paper bags can be recycled in your commingled recycling bin.');
INSERT INTO [Item] VALUES (3,'Batteries','Batteries should be never be placed in any of your kerbside bins due to its flammable nature, especially single-use type such as AAAA, single cell and 9V batteries. Instead, store in a cool and dry place pending recycling. Single-use batteries can be recycled at retail locations such as Aldi, Officeworks, and selected waste management transfer stations and facilities. Lithium-ion batteries, found in most laptops and smartphones, should be recycled as e-waste.');
INSERT INTO [Item] VALUES (4,'Dry cleaning bags','Dry cleaning bags from the laundromat are made of soft plastics. These can be recycled through a soft plastic recycling scheme. If in doubt, contact your local council.');
INSERT INTO [Item] VALUES (5,'Knives','Knives in good condition can be donated or gifted. For broken knives, make sure they are packaged securely before placing in the general waste bin.');

CREATE TABLE [Classification] (
  [class_id] int(11) NOT NULL,
  [name] varchar(50) NOT NULL,
  PRIMARY KEY ([class_id])
) 
INSERT INTO [Classification] VALUES (1,'Commingled recycling');
INSERT INTO [Classification] VALUES (2,'General waste');
INSERT INTO [Classification] VALUES (3,'Check with Council');
INSERT INTO [Classification] VALUES (4,'Recycle separately');

CREATE TABLE [Item_Class] (
  [item_id] int(11) NOT NULL,
  [class_id] int(11) NOT NULL,
  PRIMARY KEY ([item_id],[class_id]),
  CONSTRAINT [fk_item_idx] FOREIGN KEY ([item_id]) REFERENCES [Item] ([item_id]),
  CONSTRAINT [fk_class_idx] FOREIGN KEY ([class_id]) REFERENCES [Classification] ([class_id]),
)
INSERT INTO [Item_Class] VALUES (1,1);
INSERT INTO [Item_Class] VALUES (2,1);
INSERT INTO [Item_Class] VALUES (3,4);
INSERT INTO [Item_Class] VALUES (4,3);
INSERT INTO [Item_Class] VALUES (4,4);
INSERT INTO [Item_Class] VALUES (5,2);