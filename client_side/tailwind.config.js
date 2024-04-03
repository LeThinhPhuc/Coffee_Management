/** @type {import('tailwindcss').Config} */
export default {
  content: ["./index.html", "./src/**/*.{js,ts,jsx,tsx}"],
  theme: {
    extend: {
      gridTemplateColumns: {
        "auto-fit-100": "repeat(auto-fit,minmax(100px,180px))",
      },
      fontFamily: {
        palanquin: ["Palanquin", "sans-serif"],
        montserrat: ["Montserrat", "sans-serif"],
      },
      colors: {
        "darkest-brown": "#3c2f2f",
        "red-brown": "#854442",
        nude: "#dfccaf",
        wood: "#6f4436",
        "dark-nude": "#be9b7b",
      },
    },
  },
  plugins: [],
};
