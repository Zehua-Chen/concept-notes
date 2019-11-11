from argparse import ArgumentParser, Namespace

class NewTopicCreator:
    def __init__(self, dir_name: str):
        self.dir_name = dir_name

class Application:
    def __init__(self, args: Namespace):
        pass

    def run(self) -> None:
        pass

parser = ArgumentParser()
subparsers = parser.add_subparsers()

new_parser = subparsers.add_parser("new")
new_parser.add_argument(
    "--bin-dir",
    default="bin",
    type=str,
    help="Output directory")
new_parser.add_argument("name", help="Name of the topic")

package_parser = subparsers.add_parser("build")
package_parser.add_argument(
    "--bin-dir",
    default="build",
    type=str,
    help="Output directory")

args = parser.parse_args()

app = Application(args)
app.run()
