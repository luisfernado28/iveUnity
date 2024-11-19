BIN := bin
SHELL := zsh

.PHONY: clean main

main: main.tex
	latexmk \
		-synctex=1 \
		-interaction=nonstopmode \
		-pdf \
		-outdir=${BIN} \
		$<

clean:
	rm -r ${BIN}/*
