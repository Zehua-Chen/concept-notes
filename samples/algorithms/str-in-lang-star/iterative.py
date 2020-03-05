def is_string_in_lang_star(s: str, lang: str) -> bool:
    isl = [False] * len(s)

    for i in range(len(s) - 1, 0, step=-1):
        for j in range(i + 1, len(s)):
            pass
