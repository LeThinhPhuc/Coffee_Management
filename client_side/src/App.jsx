import { AppProvider } from "./context/MenuContext";
import Discount from "./components/Discount/Discount";
function App() {
  return (
    <AppProvider>
      <Discount />
    </AppProvider>
  );
}

export default App;
