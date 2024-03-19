using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtentTranslator
	/// </summary>
	/// <remarks>
	///    Generates a structured extent from unstructured.
	///
	///
	/// vtkExtentTranslator generates a structured extent from an unstructured
	/// extent.  It uses a recursive scheme that splits the largest axis.  A hard
	/// coded extent can be used for a starting point.
	/// </remarks>
	// Token: 0x020009D0 RID: 2512
	public class vtkExtentTranslator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A33D RID: 107325 RVA: 0x00245397 File Offset: 0x00243597
		static vtkExtentTranslator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtentTranslator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtentTranslator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A33E RID: 107326 RVA: 0x002453BF File Offset: 0x002435BF
		public vtkExtentTranslator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A33F RID: 107327
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtentTranslator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A340 RID: 107328 RVA: 0x002453D0 File Offset: 0x002435D0
		public new static vtkExtentTranslator New()
		{
			vtkExtentTranslator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtentTranslator.vtkExtentTranslator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtentTranslator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A341 RID: 107329 RVA: 0x00245424 File Offset: 0x00243624
		public vtkExtentTranslator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtentTranslator.vtkExtentTranslator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A342 RID: 107330 RVA: 0x00245468 File Offset: 0x00243668
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A343 RID: 107331
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtentTranslator_GetExtent_01(HandleRef pThis);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A344 RID: 107332 RVA: 0x00245474 File Offset: 0x00243674
		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkExtentTranslator.vtkExtentTranslator_GetExtent_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601A345 RID: 107333
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_GetExtent_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A346 RID: 107334 RVA: 0x002454BC File Offset: 0x002436BC
		public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkExtentTranslator.vtkExtentTranslator_GetExtent_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0601A347 RID: 107335
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_GetExtent_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A348 RID: 107336 RVA: 0x002454D4 File Offset: 0x002436D4
		public virtual void GetExtent(IntPtr _arg)
		{
			vtkExtentTranslator.vtkExtentTranslator_GetExtent_03(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A349 RID: 107337
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentTranslator_GetGhostLevel_04(HandleRef pThis);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A34A RID: 107338 RVA: 0x002454E4 File Offset: 0x002436E4
		public virtual int GetGhostLevel()
		{
			return vtkExtentTranslator.vtkExtentTranslator_GetGhostLevel_04(base.GetCppThis());
		}

		// Token: 0x0601A34B RID: 107339
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtentTranslator_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A34C RID: 107340 RVA: 0x00245504 File Offset: 0x00243704
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtentTranslator.vtkExtentTranslator_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601A34D RID: 107341
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtentTranslator_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A34E RID: 107342 RVA: 0x00245524 File Offset: 0x00243724
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtentTranslator.vtkExtentTranslator_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601A34F RID: 107343
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentTranslator_GetNumberOfPieces_07(HandleRef pThis);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A350 RID: 107344 RVA: 0x00245540 File Offset: 0x00243740
		public virtual int GetNumberOfPieces()
		{
			return vtkExtentTranslator.vtkExtentTranslator_GetNumberOfPieces_07(base.GetCppThis());
		}

		// Token: 0x0601A351 RID: 107345
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentTranslator_GetPiece_08(HandleRef pThis);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A352 RID: 107346 RVA: 0x00245560 File Offset: 0x00243760
		public virtual int GetPiece()
		{
			return vtkExtentTranslator.vtkExtentTranslator_GetPiece_08(base.GetCppThis());
		}

		// Token: 0x0601A353 RID: 107347
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentTranslator_GetSplitMode_09(HandleRef pThis);

		/// <summary>
		/// How should the streamer break up extents. Block mode
		/// tries to break an extent up into cube blocks.  It always chooses
		/// the largest axis to split.
		/// Slab mode first breaks up the Z axis.  If it gets to one slice,
		/// then it starts breaking up other axes.
		/// </summary>
		// Token: 0x0601A354 RID: 107348 RVA: 0x00245580 File Offset: 0x00243780
		public virtual int GetSplitMode()
		{
			return vtkExtentTranslator.vtkExtentTranslator_GetSplitMode_09(base.GetCppThis());
		}

		// Token: 0x0601A355 RID: 107349
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtentTranslator_GetWholeExtent_10(HandleRef pThis);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A356 RID: 107350 RVA: 0x002455A0 File Offset: 0x002437A0
		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkExtentTranslator.vtkExtentTranslator_GetWholeExtent_10(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601A357 RID: 107351
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_GetWholeExtent_11(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A358 RID: 107352 RVA: 0x002455E8 File Offset: 0x002437E8
		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkExtentTranslator.vtkExtentTranslator_GetWholeExtent_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0601A359 RID: 107353
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_GetWholeExtent_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A35A RID: 107354 RVA: 0x00245600 File Offset: 0x00243800
		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkExtentTranslator.vtkExtentTranslator_GetWholeExtent_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A35B RID: 107355
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentTranslator_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A35C RID: 107356 RVA: 0x00245610 File Offset: 0x00243810
		public override int IsA(string type)
		{
			return vtkExtentTranslator.vtkExtentTranslator_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0601A35D RID: 107357
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentTranslator_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A35E RID: 107358 RVA: 0x00245630 File Offset: 0x00243830
		public new static int IsTypeOf(string type)
		{
			return vtkExtentTranslator.vtkExtentTranslator_IsTypeOf_14(type);
		}

		// Token: 0x0601A35F RID: 107359
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtentTranslator_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A360 RID: 107360 RVA: 0x0024564C File Offset: 0x0024384C
		public new vtkExtentTranslator NewInstance()
		{
			vtkExtentTranslator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtentTranslator.vtkExtentTranslator_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtentTranslator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A361 RID: 107361
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentTranslator_PieceToExtent_17(HandleRef pThis);

		/// <summary>
		/// These are the main methods that should be called. These methods
		/// are responsible for converting a piece to an extent. The signatures
		/// without arguments are only thread safe when each thread accesses a
		/// different instance. The signatures with arguments are fully thread
		/// safe.
		/// </summary>
		// Token: 0x0601A362 RID: 107362 RVA: 0x002456A8 File Offset: 0x002438A8
		public virtual int PieceToExtent()
		{
			return vtkExtentTranslator.vtkExtentTranslator_PieceToExtent_17(base.GetCppThis());
		}

		// Token: 0x0601A363 RID: 107363
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentTranslator_PieceToExtentByPoints_18(HandleRef pThis);

		/// <summary>
		/// These are the main methods that should be called. These methods
		/// are responsible for converting a piece to an extent. The signatures
		/// without arguments are only thread safe when each thread accesses a
		/// different instance. The signatures with arguments are fully thread
		/// safe.
		/// </summary>
		// Token: 0x0601A364 RID: 107364 RVA: 0x002456C8 File Offset: 0x002438C8
		public virtual int PieceToExtentByPoints()
		{
			return vtkExtentTranslator.vtkExtentTranslator_PieceToExtentByPoints_18(base.GetCppThis());
		}

		// Token: 0x0601A365 RID: 107365
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentTranslator_PieceToExtentThreadSafe_19(HandleRef pThis, int piece, int numPieces, int ghostLevel, IntPtr wholeExtent, IntPtr resultExtent, int splitMode, int byPoints);

		/// <summary>
		/// These are the main methods that should be called. These methods
		/// are responsible for converting a piece to an extent. The signatures
		/// without arguments are only thread safe when each thread accesses a
		/// different instance. The signatures with arguments are fully thread
		/// safe.
		/// </summary>
		// Token: 0x0601A366 RID: 107366 RVA: 0x002456E8 File Offset: 0x002438E8
		public virtual int PieceToExtentThreadSafe(int piece, int numPieces, int ghostLevel, IntPtr wholeExtent, IntPtr resultExtent, int splitMode, int byPoints)
		{
			return vtkExtentTranslator.vtkExtentTranslator_PieceToExtentThreadSafe_19(base.GetCppThis(), piece, numPieces, ghostLevel, wholeExtent, resultExtent, splitMode, byPoints);
		}

		// Token: 0x0601A367 RID: 107367
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtentTranslator_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A368 RID: 107368 RVA: 0x00245714 File Offset: 0x00243914
		public new static vtkExtentTranslator SafeDownCast(vtkObjectBase o)
		{
			vtkExtentTranslator vtkExtentTranslator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtentTranslator.vtkExtentTranslator_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtentTranslator = (vtkExtentTranslator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtentTranslator.Register(null);
				}
			}
			return vtkExtentTranslator;
		}

		// Token: 0x0601A369 RID: 107369
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_SetExtent_21(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A36A RID: 107370 RVA: 0x00245793 File Offset: 0x00243993
		public virtual void SetExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetExtent_21(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0601A36B RID: 107371
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_SetExtent_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A36C RID: 107372 RVA: 0x002457AB File Offset: 0x002439AB
		public virtual void SetExtent(IntPtr _arg)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetExtent_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A36D RID: 107373
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_SetGhostLevel_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A36E RID: 107374 RVA: 0x002457BB File Offset: 0x002439BB
		public virtual void SetGhostLevel(int _arg)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetGhostLevel_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A36F RID: 107375
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_SetNumberOfPieces_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A370 RID: 107376 RVA: 0x002457CB File Offset: 0x002439CB
		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetNumberOfPieces_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A371 RID: 107377
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_SetPiece_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A372 RID: 107378 RVA: 0x002457DB File Offset: 0x002439DB
		public virtual void SetPiece(int _arg)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetPiece_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A373 RID: 107379
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_SetSplitModeToBlock_26(HandleRef pThis);

		/// <summary>
		/// How should the streamer break up extents. Block mode
		/// tries to break an extent up into cube blocks.  It always chooses
		/// the largest axis to split.
		/// Slab mode first breaks up the Z axis.  If it gets to one slice,
		/// then it starts breaking up other axes.
		/// </summary>
		// Token: 0x0601A374 RID: 107380 RVA: 0x002457EB File Offset: 0x002439EB
		public void SetSplitModeToBlock()
		{
			vtkExtentTranslator.vtkExtentTranslator_SetSplitModeToBlock_26(base.GetCppThis());
		}

		// Token: 0x0601A375 RID: 107381
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_SetSplitModeToXSlab_27(HandleRef pThis);

		/// <summary>
		/// How should the streamer break up extents. Block mode
		/// tries to break an extent up into cube blocks.  It always chooses
		/// the largest axis to split.
		/// Slab mode first breaks up the Z axis.  If it gets to one slice,
		/// then it starts breaking up other axes.
		/// </summary>
		// Token: 0x0601A376 RID: 107382 RVA: 0x002457FA File Offset: 0x002439FA
		public void SetSplitModeToXSlab()
		{
			vtkExtentTranslator.vtkExtentTranslator_SetSplitModeToXSlab_27(base.GetCppThis());
		}

		// Token: 0x0601A377 RID: 107383
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_SetSplitModeToYSlab_28(HandleRef pThis);

		/// <summary>
		/// How should the streamer break up extents. Block mode
		/// tries to break an extent up into cube blocks.  It always chooses
		/// the largest axis to split.
		/// Slab mode first breaks up the Z axis.  If it gets to one slice,
		/// then it starts breaking up other axes.
		/// </summary>
		// Token: 0x0601A378 RID: 107384 RVA: 0x00245809 File Offset: 0x00243A09
		public void SetSplitModeToYSlab()
		{
			vtkExtentTranslator.vtkExtentTranslator_SetSplitModeToYSlab_28(base.GetCppThis());
		}

		// Token: 0x0601A379 RID: 107385
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_SetSplitModeToZSlab_29(HandleRef pThis);

		/// <summary>
		/// How should the streamer break up extents. Block mode
		/// tries to break an extent up into cube blocks.  It always chooses
		/// the largest axis to split.
		/// Slab mode first breaks up the Z axis.  If it gets to one slice,
		/// then it starts breaking up other axes.
		/// </summary>
		// Token: 0x0601A37A RID: 107386 RVA: 0x00245818 File Offset: 0x00243A18
		public void SetSplitModeToZSlab()
		{
			vtkExtentTranslator.vtkExtentTranslator_SetSplitModeToZSlab_29(base.GetCppThis());
		}

		// Token: 0x0601A37B RID: 107387
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_SetSplitPath_30(HandleRef pThis, int len, IntPtr splitpath);

		/// <summary>
		/// By default the translator creates N structured subextents by repeatedly
		/// splitting the largest current dimension until there are N pieces.
		/// If you do not want it always split the largest dimension, for instance when the
		/// shortest dimension is the slowest changing and thus least coherent in memory,
		/// use this to tell the translator which dimensions to split.
		/// </summary>
		// Token: 0x0601A37C RID: 107388 RVA: 0x00245827 File Offset: 0x00243A27
		public void SetSplitPath(int len, IntPtr splitpath)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetSplitPath_30(base.GetCppThis(), len, splitpath);
		}

		// Token: 0x0601A37D RID: 107389
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_SetWholeExtent_31(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A37E RID: 107390 RVA: 0x00245838 File Offset: 0x00243A38
		public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetWholeExtent_31(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0601A37F RID: 107391
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentTranslator_SetWholeExtent_32(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the Piece/NumPieces. Set the WholeExtent and then call PieceToExtent.
		/// The result can be obtained from the Extent ivar.
		/// </summary>
		// Token: 0x0601A380 RID: 107392 RVA: 0x00245850 File Offset: 0x00243A50
		public virtual void SetWholeExtent(IntPtr _arg)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetWholeExtent_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A381 RID: 107393
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtentTranslator_UPDATE_SPLIT_MODE_33(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key used to request a particular split mode.
		/// This is used by vtkStreamingDemandDrivenPipeline.
		/// </summary>
		// Token: 0x0601A382 RID: 107394 RVA: 0x00245860 File Offset: 0x00243A60
		public static vtkInformationIntegerRequestKey UPDATE_SPLIT_MODE()
		{
			vtkInformationIntegerRequestKey vtkInformationIntegerRequestKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtentTranslator.vtkExtentTranslator_UPDATE_SPLIT_MODE_33(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerRequestKey = (vtkInformationIntegerRequestKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerRequestKey.Register(null);
				}
			}
			return vtkInformationIntegerRequestKey;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C6D RID: 7277
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtentTranslator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C6E RID: 7278
		public new static readonly string MRClassNameKey = "class vtkExtentTranslator";

		/// <summary>
		/// By default the translator creates N structured subextents by repeatedly
		/// splitting the largest current dimension until there are N pieces.
		/// If you do not want it always split the largest dimension, for instance when the
		/// shortest dimension is the slowest changing and thus least coherent in memory,
		/// use this to tell the translator which dimensions to split.
		/// </summary>
		// Token: 0x020009D1 RID: 2513
		public enum Modes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001C70 RID: 7280
			BLOCK_MODE = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001C71 RID: 7281
			X_SLAB_MODE = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001C72 RID: 7282
			Y_SLAB_MODE,
			/// <summary>enum member</summary>
			// Token: 0x04001C73 RID: 7283
			Z_SLAB_MODE
		}
	}
}
