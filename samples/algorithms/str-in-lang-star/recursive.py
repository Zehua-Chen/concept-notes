import re


def is_string_in_lang_star(s: str, lang: str) -> bool:
    print("def is_string_in_lang_star(s={}, lang={}):".format(s, lang))

    if len(s) == 0:
        return True

    if re.fullmatch(lang, s) is not None:
        return True

    for i in range(0, len(s) - 1):
        print("  slice 1 = {}, slice 2 = {}".format(s[0:i + 1], s[i + 1:]))
        if re.fullmatch(lang, s[0:i + 1]) and is_string_in_lang_star(s[i + 1:], lang):
            return True

    return False


if __name__ == "__main__":
    print(is_string_in_lang_star("aaa", "a"))
