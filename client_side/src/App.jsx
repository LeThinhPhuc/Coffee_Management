import React, { useState, useEffect } from 'react';
import './App.css'; // Tailwind CSS file
import { AppProvider } from './context/MenuContext';
import OrderPage from './components/OrderPage/OrderPage';

function App() {
  const [windowHeight, setWindowHeight] = useState(window.innerHeight);

  useEffect(() => {
    const handleResize = () => {
      setWindowHeight(window.innerHeight);
    };

    window.addEventListener('resize', handleResize);

    return () => {
      window.removeEventListener('resize', handleResize);
    };
  }, []);

  return (
    // <div className="flex h-screen">
    //   {/* Màn hình trái */}
    //   <div className="flex-1 overflow-auto p-4" style={{ height: windowHeight }}>
    //     {/* Nội dung của màn hình trái */}
    //     <h1 className="text-2xl font-bold">Màn hình trái</h1>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
        
    //     {/* Các phần khác của màn hình trái */}
    //   </div>

    //   {/* Màn hình phải */}
    //   <div className="flex-1 overflow-auto p-4">
    //     {/* Nội dung của màn hình phải */}
    //     <h1 className="text-2xl font-bold">Màn hình phải</h1>
    //     <div className="h-full overflow-auto">
    //       {/* Nội dung có thể vượt quá kích thước của màn hình phải */}
    //       <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //       <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
    //     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae tortor sed massa consequat consequat. Pellentesque id eros ut dolor dapibus rhoncus. Donec mattis leo vitae erat placerat, at feugiat sem bibendum. Ut vel arcu orci.</p>
        
    //       {/* Các phần khác của màn hình phải */}
    //     </div>
    //   </div>
    // </div>

    <AppProvider>
      <OrderPage></OrderPage>
    </AppProvider>
  );
}

export default App;
