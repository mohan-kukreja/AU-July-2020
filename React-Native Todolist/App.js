import { StatusBar } from 'expo-status-bar';
import { createStackNavigator } from '@react-navigation/stack';
import { NavigationContainer } from '@react-navigation/native';
import React from 'react';
import Login from './src/component/Login'
import Todo from './src/component/Todo'
import { StyleSheet, Text, View } from 'react-native';


const Stack = createStackNavigator();

export default function App() {
  return (

    <NavigationContainer>
     
      <Stack.Navigator>
        <Stack.Screen name="Login" component={Login} />
        <Stack.Screen name="Todo" component={Todo} />
        {/* <Stack.Screen name="Todo" component={Todolist} /> */}
        
      </Stack.Navigator>
    </NavigationContainer>
   
  
  );
}

// const styles = StyleSheet.create({
//   container: {
//     flex: 1,
//     backgroundColor: '#fff',
//     alignItems: 'center',
//     justifyContent: 'center',
//   },
// });
