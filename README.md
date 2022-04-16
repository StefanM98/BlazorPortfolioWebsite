# Blazor WebAssembly (WASM) .NET Hosted Personal Portfolio

Check it out here: [stefandev.com](https://stefandev.com)

## Overview 
This is a simple portfolio built with the .NET 6 hosted version of [Blazor WebAssembly](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor) technology. I developed this portfolio to showcase my skills and experience as a Software Engineer while also learning new technologies.

### Technologies/Tools used
- [Blazor WebAssembly](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
- C# & .NET Core 6
- JavaScript
- [Tailwind CSS](https://tailwindcss.com/)
- [DaisyUI](https://daisyui.com/)

### Architecture
The solution contains 3 projects:
- PortfolioWebsite.Client.csproj: The Blazor client application
- PortfolioWebsite.Server.csproj: The .NET Core backend
- PortfolioWebsite.Shared.csproj: The model that is shared across both projects

## Current Status
The portfolio is currently in a very early stage of development. So far, I have completed the following tasks:
- :heavy_check_mark: Setup the project structure
- :heavy_check_mark: Setup the project dependencies
- :heavy_check_mark: Created a temporary landing page with links to my LinkedIn profile and resume
- :heavy_check_mark: Deployed the project to a [Digital Ocean](https://www.digitalocean.com/) droplet

## Running the project
1. Install the latest Visual Studio 2022 (at least v17.0.1)
2. Clone the repository
3. Open the solution in Visual Studio and press F5 to build and run (with debugging)

## License
This project is licensed under the [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.en.html).
Please see the [LICENSE.md](LICENSE.md) file for more information.