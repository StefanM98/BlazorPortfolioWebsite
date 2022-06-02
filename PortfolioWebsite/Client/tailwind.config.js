module.exports = {
  content: [
    "**/*.html",
    "**/*.razor",
  ],
  theme: {
    extend: {},
  },
  darkMode: true,
  plugins: [
    require('@tailwindcss/typography'),
    require("daisyui")
  ],
  daisyui: {
    themes: [
      { dark: {
          ...require("daisyui/src/colors/themes")["[data-theme=night]"],
          "primary": "#b3c5ef",
          "primary-focus": "#b3c5ef",
      }}
    ]
  }
}
