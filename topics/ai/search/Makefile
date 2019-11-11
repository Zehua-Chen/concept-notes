BIN=bin
PDF=index.pdf

all: $(BIN)/$(PDF)

$(BIN):
	mkdir $(BIN)

$(BIN)/$(PDF): index.tex $(wildcard sections/*.tex) $(wildcard config/*.tex) $(BIN)
	pdflatex -output-directory=$(BIN)  $<

.PHONY: clean
clean:
	rm -rf $(BIN)

.PHONY: open
open:
	open $(BIN)/$(PDF)