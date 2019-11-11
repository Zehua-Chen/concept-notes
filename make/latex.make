all: $(BIN)/$(PDF)

$(BIN):
	mkdir $(BIN)

$(BIN)/$(PDF): $(SRCS) | $(BIN)
	pdflatex -output-directory=$(BIN)  $<

.PHONY: clean
clean:
	rm -rf $(BIN)

.PHONY: open
open:
	open $(BIN)/$(PDF)