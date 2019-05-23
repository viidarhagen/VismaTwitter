# Nordic Cool 3 for Bootstrap

This theme goes on top of Twitter Bootstrap 3.4 and is using Nordic Cool 3 styles created by Visma.

For release notes and what's new in this version, go to [confluence.visma.com/display/VIUX/Release+notes](https://confluence.visma.com/display/VIUX/Release+notes)

## Requirements

- The standard CSS files from Bootstrap - `bootstrap.min.css` (included in this package)
- Scripts:
	- `bootstrap.js`
	- a recent version of jQuery (included as `jquery.js` in the `js` folder)

## What to include

### Visma additions

The preferred way is to use the packaged and minified version: `nc.min.css`

If you want access to the source files (Less format), the full package is available at [https://stash.visma.com/projects/NC/repos/nc3/browse](https://stash.visma.com/projects/NC/repos/nc3/browse)

### JS files to include

- `bootstrap-tabdrop.js`
- `hideVertMenu.js`
- `visma-additional.js`

### Other files

- The graphics (`img` folder)

### Fonts

By default, fonts are loaded from Google Fonts. See the `start-here.html` file for how to do it. If you want to load fonts locally, we have included all the necessary font files to do that. You probably want to update the relevant Less files and recompile to have a clean version.

In addition, the login page uses PF Beau Sans, which is Visma's corporate font. This font is loaded from `font.visma.com`, and we have also included the necessary fonts if you want to host the files locally. 

## How to install

### Bower

The command below will install the latest version of Nordic Cool 3:

    bower install https://stash.visma.com/scm/nc/nc3.git

### NPM

All releases of Nordic Cool 3 are available through the Visma Artifactory Repository. See the instructions here: [Using Common Assets Components in your web app](https://confluence.visma.com/display/VIUX/Using+Common+Assets+Components+in+your+web+app)

    npm install @visma/nordic-cool --s

Or do it manually. Copy and extract the NC3 zip package you can find on [ux.visma.com](http://ux.visma.com/weblibrary/latest/).