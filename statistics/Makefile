CHAPTERS = $(wildcard chapters/*.tex)
CONFIGS = $(wildcard config/*.tex)
TEXFLAGS = -output-directory=bin

all: bin/index.pdf

bin:
	mkdir bin

bin/index.pdf: index.tex $(CHAPTERS) $(CONFIGS) bin
	pdflatex $(TEXFLAGS) $<
	
.PHONY: draft
draft: index.tex $(CHAPTERS) $(CONFIGS) bin
	pdflatex $(TEXFLAGS) -draftmode $<