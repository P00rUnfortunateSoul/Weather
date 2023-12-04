// File generated by FlutterFire CLI.
// ignore_for_file: lines_longer_than_80_chars, avoid_classes_with_only_static_members
import 'package:firebase_core/firebase_core.dart' show FirebaseOptions;
import 'package:flutter/foundation.dart'
    show defaultTargetPlatform, kIsWeb, TargetPlatform;

/// Default [FirebaseOptions] for use with your Firebase apps.
///
/// Example:
/// ```dart
/// import 'firebase_options.dart';
/// // ...
/// await Firebase.initializeApp(
///   options: DefaultFirebaseOptions.currentPlatform,
/// );
/// ```
class DefaultFirebaseOptions {
  static FirebaseOptions get currentPlatform {
    if (kIsWeb) {
      return web;
    }
    switch (defaultTargetPlatform) {
      case TargetPlatform.android:
        return android;
      case TargetPlatform.iOS:
        return ios;
      case TargetPlatform.macOS:
        return macos;
      case TargetPlatform.windows:
        throw UnsupportedError(
          'DefaultFirebaseOptions have not been configured for windows - '
          'you can reconfigure this by running the FlutterFire CLI again.',
        );
      case TargetPlatform.linux:
        throw UnsupportedError(
          'DefaultFirebaseOptions have not been configured for linux - '
          'you can reconfigure this by running the FlutterFire CLI again.',
        );
      default:
        throw UnsupportedError(
          'DefaultFirebaseOptions are not supported for this platform.',
        );
    }
  }

  static const FirebaseOptions web = FirebaseOptions(
    apiKey: 'AIzaSyCEOE0slir8U2jSCexkOPlUHgbrXzzCfZY',
    appId: '1:509777019601:web:8ca0fa4401d8f197b1fbf0',
    messagingSenderId: '509777019601',
    projectId: 'crud-20482',
    authDomain: 'crud-20482.firebaseapp.com',
    storageBucket: 'crud-20482.appspot.com',
    measurementId: 'G-GKQCBCL0JM',
  );

  static const FirebaseOptions android = FirebaseOptions(
    apiKey: 'AIzaSyB4IiIz_P_lpfT0N0njvMbqd6_KvN8nTwM',
    appId: '1:509777019601:android:41fe50f4c7324a62b1fbf0',
    messagingSenderId: '509777019601',
    projectId: 'crud-20482',
    storageBucket: 'crud-20482.appspot.com',
  );

  static const FirebaseOptions ios = FirebaseOptions(
    apiKey: 'AIzaSyDZneLCj78buOLfJEfGpV6mH47ehpZ6Clk',
    appId: '1:509777019601:ios:29dafd678d71a7a0b1fbf0',
    messagingSenderId: '509777019601',
    projectId: 'crud-20482',
    storageBucket: 'crud-20482.appspot.com',
    iosBundleId: 'com.example.shirtshop',
  );

  static const FirebaseOptions macos = FirebaseOptions(
    apiKey: 'AIzaSyDZneLCj78buOLfJEfGpV6mH47ehpZ6Clk',
    appId: '1:509777019601:ios:ce7f045822308dabb1fbf0',
    messagingSenderId: '509777019601',
    projectId: 'crud-20482',
    storageBucket: 'crud-20482.appspot.com',
    iosBundleId: 'com.example.shirtshop.RunnerTests',
  );
}