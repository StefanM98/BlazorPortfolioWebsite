# Blazor WebAssembly (WASM) .NET Hosted Portfolio Site

[![Build Status](https://dev.azure.com/stefan-dev-1/BlazorPortfolioWebsite/_apis/build/status/StefanM98.BlazorPortfolioWebsite?branchName=main)](https://dev.azure.com/stefan-dev-1/BlazorPortfolioWebsite/_build/latest?definitionId=1&branchName=main)

Check it out here: [stefandev.com](https://stefandev.com)

## Overview 
This is a simple portfolio and blog built with the .NET 6 hosted version of [Blazor WebAssembly](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor). I'm building this application to showcase my skills and experience as a Software Engineer while also taking the opportunity to become more proficient in C# and .NET. In addition, I will be implementing a personal blog, where I will write about development topics that interest me and work on improving my technical writing skills.

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
The portfolio is currently in an early stage of development. So far, I have completed the following tasks:

:heavy_check_mark: Setup the project structure \
:heavy_check_mark: Setup the project dependencies \
:heavy_check_mark: Created a temporary landing page \
:heavy_check_mark: Deployed the project to a [Digital Ocean](https://www.digitalocean.com/) droplet 
:heavy_check_mark: Finished the main page \

## Planned Features
- [ ] Add featured projects section
- [ ] Add blog
- [ ] Render globalized and localized content from DB

## Running the project
1. Install the latest Visual Studio 2022 (at least v17.0.1)
2. Clone the repository
3. Open the solution in Visual Studio and press F5 to build and run (with debugging)

## License
This project is licensed under the [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.en.html).
Please see the [LICENSE.md](LICENSE.md) file for more information.
