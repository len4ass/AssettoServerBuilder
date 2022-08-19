# Assetto Server Builder
 
## Info
A winforms app that saves you 10 minutes of your time by automating file merging.

![Assetto Server Builder image](https://i.imgur.com/5ugjLLC.png)

## How to use
- `Browse` will let you navigate through directories with Windows GUI
- `Server name` will patch a name of your server to whatever you type in there
- `AssettoServer base` expects an absolute path to a folder containing [AssettoServer](https://github.com/compujuckel/AssettoServer) files
- `Packed server` expects an absolute path to a zip archive with server tracks and cars you made in [Content Manager](https://acstuff.ru/app/)
- `AI folder (optional)` expects an absolute path to the folder where you keep your splines for given track
- `Extra config (optional)` expects an absolute path to extra_cfg.yml 
- `AI=fixed for ... cars (optional)` will add `AI=fixed` to first ... cars (experimental, bad implementation)
- `TCP port (optional)` will set `TCP_PORT` in `server_cfg.ini` to that value
- `UDP port (optional)` will set `UDP_PORT` in `server_cfg.ini` to that value
- `HTTP port (optional)` will set `HTTP_PORT` in `server_cfg.ini` to that value
- `Output folder` expects an absolute path to the folder where you want the merge result
- `Build and pack` starts merging proccess and packs the result in ZIP (one directory up relative to output folder)

Application automatically saves your session and restores it on the next launch so you don't need to put in the paths again. You can also save session in a preset and then load it back in.