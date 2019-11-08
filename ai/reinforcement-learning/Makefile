BIN=bin
PDF=index.pdf
SOURCES=index.tex $(wildcard config/*.tex) $(wildcard sections/*.tex)

all: $(BIN)/$(PDF)

$(BIN):
	mkdir $(BIN)

$(BIN)/$(PDF): $(SOURCES)  $(BIN)
	pdflatex -output-directory=$(BIN)  $<

.PHONY: clean
clean:
	rm -rf $(BIN)

.PHONY: open
open:
	open $(BIN)/$(PDF)