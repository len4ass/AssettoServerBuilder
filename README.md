# Assetto Server Builder
 
## Info
A winforms app that saves you 5 minutes of your time by automating file merging.

![Assetto Server Builder image](https://i.imgur.com/lE3wCdx.png)

## How to use
- `Browse` will let you navigate through directories with Windows GUI
- `Server base` expects an absolute path to a folder containing [AssettoServer](https://github.com/compujuckel/AssettoServer) files
- `Packed server` expects an absolute path to a zip archive with server tracks and cars you made in [Content Manager](https://acstuff.ru/app/)
- `AI folder (optional)` expects an absolute path to the folder where you keep your splines for given track
- `Extra config (optional)` expects an absolute path to extra_cfg.yml 
- `AI=fixed for ... cars (optional)` will add `AI=fixed` to first ... cars (experimental, bad implementation)
- `Output folder` expects an absolute path to the folder where you want the merge result
- `Build and pack` starts merging proccess and packs the result in ZIP (one directory up relative to output folder)

Application automatically saves your session and restores it on the next launch so you don't need to put in the paths again (will introduce presets later).