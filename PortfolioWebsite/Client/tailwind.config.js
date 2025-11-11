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
      {
        dark: {
          "primary": "#b3c5ef",
          "primary-focus": "#b3c5ef",
          "base-100": "#1d1f2f",
        }
      }
    ]
  }
}
