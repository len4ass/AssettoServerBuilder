# Assetto Server Builder
 
## Info
A winforms app that saves you a lot of time by automating file merging.

![Assetto Server Builder image](https://i.imgur.com/PKZ4W4a.png)

*Main window*
\
\
\
![Assetto Server Builder entry list modifier image](https://i.imgur.com/EJJl8EY.png)

*Entry list modifier*



## How to use

#### Main window
- `Browse` will let you navigate through directories with Windows GUI
- `Server name` doesn't do anything except it's useful for saving presets and shows up in entry list window when building
- `AssettoServer base` expects an absolute path to a folder containing [AssettoServer](https://github.com/compujuckel/AssettoServer) files
- `Packed server` expects an absolute path to a zip archive with server tracks and cars you made in [Content Manager](https://acstuff.ru/app/)
- `AI folder (optional)` expects an absolute path to the folder where you keep your splines for given track
- `Extra config (optional)` expects an absolute path to `extra_cfg.yml`
- `Server config (optional)` expects an absolute path to `server_cfg.ini`
- `CSP extra config (optional)` expects an absolute path to `csp_extra_options.ini`
- `Welcome message (optional)` expects an absolute path to `welcome.txt`
- `Output folder` expects an absolute path to the folder where you want the merge result
- `Modify entry_list` enables or disables entry list modifier once you press build and pack
- `Build` starts merging proccess and packs the result in ZIP (one directory up relative to output folder)
  - `Current preset` - builds and packs from current settings
  - `Multiple presets` - builds and packs from multiple chosen .json presets (simply select multiple files in a dialog window and click Open)

#### Entry list
- `Sort entry_list` is useful when you want to make sure traffic or player cars are loaded first or last
  - `entries with AI=none go first` means that all user playable cars will be placed and loaded before AI cars (that is useful for SRP, because main pits on Overload layout only allow up to 40 cars and exceeding this limit will send you to other pits)
  - `entries with AI=fixed go first` does the opposite - it places AI cars first, after that the user playable once (this can be useful if your entry_list.ini in content manager is broken and you love to change playable cars - entries are not ordered by ascending in entry_list but show up just fine in Content Manager)
- `Check for first/last ... cars (press Apply to confirm)` sets AI=fixed for first or last ... cars in the list
- `Check all` sets AI=fixed for all cars in the list
- `Uncheck all` sets AI=none for all cars in the list

Application automatically saves your session and restores it on the next launch so you don't need to put in the paths again. You can also save session in a preset and then load it back in.