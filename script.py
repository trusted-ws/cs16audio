########################
# Generate C# code for
# switch() with .wav
# files.
########################


from os import listdir
from os.path import isfile, join
import pathlib
import os

def generate():

    dir_name = str(pathlib.Path(__file__).parent.absolute())
    name = dir_name.split('\\')[-1]

    files = [f for f in listdir('.') if isfile(join('.', f))]

    for f in files:
        print(f"Processing: {f}...")


        # Write to file

        if(f.split('.')[-1] == "wav"):
            with open('switch.txt', 'a') as sw:
                sw.write(f"""
            case \"{f}\":
                basePath += @\"\\{name}\";
                break;
                      """)



dires = [x[0] for x in os.walk('.')]

for i in range(1, len(dires)):
    os.chdir(dires[i])
    os.remove('script.py')
    os.remove('switch.txt')
    generate()
    os.chdir('../')


