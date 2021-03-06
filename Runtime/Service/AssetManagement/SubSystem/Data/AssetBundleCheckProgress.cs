﻿// zlib/libpng License
//
// Copyright (c) 2018 Sinoa
//
// This software is provided 'as-is', without any express or implied warranty.
// In no event will the authors be held liable for any damages arising from the use of this software.
// Permission is granted to anyone to use this software for any purpose,
// including commercial applications, and to alter it and redistribute it freely,
// subject to the following restrictions:
//
// 1. The origin of this software must not be misrepresented; you must not claim that you wrote the original software.
//    If you use this software in a product, an acknowledgment in the product documentation would be appreciated but is not required.
// 2. Altered source versions must be plainly marked as such, and must not be misrepresented as being the original software.
// 3. This notice may not be removed or altered from any source distribution.

namespace IceMilkTea.Service
{
    /// <summary>
    /// アセットバンドルのチェック状態を表現した列挙型です
    /// </summary>
    public enum AssetBundleCheckStatus
    {
        /// <summary>
        /// マニフェストから情報を取得しています
        /// </summary>
        GetManifestInfo,

        /// <summary>
        /// 新規追加または更新が必要なアセットバンドルの存在チェック中です
        /// </summary>
        NewerAndUpdateCheck,

        /// <summary>
        /// 削除するべきアセットバンドルの存在チェック中です
        /// </summary>
        RemoveContentGroupCheck,
    }



    /// <summary>
    /// アセットバンドルのチェック進捗情報を保持した構造体です
    /// </summary>
    public struct AssetBundleCheckProgress
    {
        /// <summary>
        /// 現在のチェックステータス
        /// </summary>
        public AssetBundleCheckStatus Status;


        /// <summary>
        /// チェック中のアセットバンドル名
        /// </summary>
        public string AssetBundleName;


        /// <summary>
        /// 現在のステータスに対する、トータルのチェックアセットバンドル数
        /// </summary>
        public int TotalCount;


        /// <summary>
        /// 現在のステータスに対する、チェック済みのアセットバンドル数
        /// </summary>
        public int TotalCheckedCount;



        /// <summary>
        /// AssetBundleCheckProgress のインスタンスを初期化します
        /// </summary>
        /// <param name="status">チェックステータス</param>
        /// <param name="assetBundleName">チェック中のアセットバンドル名</param>
        /// <param name="totalCount">チェックするトータル数</param>
        /// <param name="totalChecked">チェックした数</param>
        public AssetBundleCheckProgress(AssetBundleCheckStatus status, string assetBundleName, int totalCount, int totalChecked)
        {
            // パラメータを全て素直に受け取る
            Status = status;
            AssetBundleName = assetBundleName;
            TotalCount = totalCount;
            TotalCheckedCount = totalChecked;
        }
    }
}