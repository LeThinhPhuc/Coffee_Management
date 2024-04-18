import { AppProvider } from "./context/MenuContext";
import Statistic from "./components/Statistic/Statistic";
function App() {
  return (
    <AppProvider>
      <Statistic />
    </AppProvider>
  );
}

export default App;
