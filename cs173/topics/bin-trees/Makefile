SRCS = index.tex $(wildcard subtopics/*.tex)

index.pdf: $(SRCS)
	pdflatex $<
	
clean:
	rm -f index.pdf index.out, index.log index.toc