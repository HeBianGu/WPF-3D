using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDicer
	/// </summary>
	/// <remarks>
	///    abstract superclass to divide dataset into pieces
	///
	/// Subclasses of vtkDicer divides the input dataset into separate
	/// pieces.  These pieces can then be operated on by other filters
	/// (e.g., vtkThreshold). One application is to break very large
	/// polygonal models into pieces and performing viewing and occlusion
	/// culling on the pieces. Multiple pieces can also be streamed through
	/// the visualization pipeline.
	///
	/// To use this filter, you must specify the execution mode of the
	/// filter; i.e., set the way that the piece size is controlled (do
	/// this by setting the DiceMode ivar). The filter does not change the
	/// geometry or topology of the input dataset, rather it generates
	/// integer numbers that indicate which piece a particular point
	/// belongs to (i.e., it modifies the point and cell attribute
	/// data). The integer number can be placed into the output scalar
	/// data, or the output field data.
	///
	/// @warning
	/// The number of pieces generated may not equal the specified number
	/// of pieces. Use the method GetNumberOfActualPieces() after filter
	/// execution to get the actual number of pieces generated.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOBBDicer vtkConnectedDicer vtkSpatialDicer
	/// </seealso>
	// Token: 0x02000893 RID: 2195
	public class vtkDicer : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016C82 RID: 93314 RVA: 0x002009FF File Offset: 0x001FEBFF
		static vtkDicer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDicer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDicer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016C83 RID: 93315 RVA: 0x00200A27 File Offset: 0x001FEC27
		public vtkDicer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016C84 RID: 93316 RVA: 0x00200A35 File Offset: 0x001FEC35
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016C85 RID: 93317
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDicer_FieldDataOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which controls whether to generate point scalar
		/// data or point field data. If this flag is off, scalar data is
		/// generated.  Otherwise, field data is generated. Note that the
		/// generated the data are integer numbers indicating which piece a
		/// particular point belongs to.
		/// </summary>
		// Token: 0x06016C86 RID: 93318 RVA: 0x00200A40 File Offset: 0x001FEC40
		public virtual void FieldDataOff()
		{
			vtkDicer.vtkDicer_FieldDataOff_01(base.GetCppThis());
		}

		// Token: 0x06016C87 RID: 93319
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDicer_FieldDataOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which controls whether to generate point scalar
		/// data or point field data. If this flag is off, scalar data is
		/// generated.  Otherwise, field data is generated. Note that the
		/// generated the data are integer numbers indicating which piece a
		/// particular point belongs to.
		/// </summary>
		// Token: 0x06016C88 RID: 93320 RVA: 0x00200A4F File Offset: 0x001FEC4F
		public virtual void FieldDataOn()
		{
			vtkDicer.vtkDicer_FieldDataOn_02(base.GetCppThis());
		}

		// Token: 0x06016C89 RID: 93321
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDicer_GetDiceMode_03(HandleRef pThis);

		/// <summary>
		/// Specify the method to determine how many pieces the data should be
		/// broken into. By default, the number of points per piece is used.
		/// </summary>
		// Token: 0x06016C8A RID: 93322 RVA: 0x00200A60 File Offset: 0x001FEC60
		public virtual int GetDiceMode()
		{
			return vtkDicer.vtkDicer_GetDiceMode_03(base.GetCppThis());
		}

		// Token: 0x06016C8B RID: 93323
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDicer_GetDiceModeMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Specify the method to determine how many pieces the data should be
		/// broken into. By default, the number of points per piece is used.
		/// </summary>
		// Token: 0x06016C8C RID: 93324 RVA: 0x00200A80 File Offset: 0x001FEC80
		public virtual int GetDiceModeMaxValue()
		{
			return vtkDicer.vtkDicer_GetDiceModeMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06016C8D RID: 93325
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDicer_GetDiceModeMinValue_05(HandleRef pThis);

		/// <summary>
		/// Specify the method to determine how many pieces the data should be
		/// broken into. By default, the number of points per piece is used.
		/// </summary>
		// Token: 0x06016C8E RID: 93326 RVA: 0x00200AA0 File Offset: 0x001FECA0
		public virtual int GetDiceModeMinValue()
		{
			return vtkDicer.vtkDicer_GetDiceModeMinValue_05(base.GetCppThis());
		}

		// Token: 0x06016C8F RID: 93327
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDicer_GetFieldData_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which controls whether to generate point scalar
		/// data or point field data. If this flag is off, scalar data is
		/// generated.  Otherwise, field data is generated. Note that the
		/// generated the data are integer numbers indicating which piece a
		/// particular point belongs to.
		/// </summary>
		// Token: 0x06016C90 RID: 93328 RVA: 0x00200AC0 File Offset: 0x001FECC0
		public virtual int GetFieldData()
		{
			return vtkDicer.vtkDicer_GetFieldData_06(base.GetCppThis());
		}

		// Token: 0x06016C91 RID: 93329
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDicer_GetMemoryLimit_07(HandleRef pThis);

		/// <summary>
		/// Control piece size based on a memory limit.  (This ivar has
		/// effect only when the DiceMode is set to
		/// SetDiceModeToMemoryLimit()). The memory limit should be set in
		/// kibibytes (1024 bytes).
		/// </summary>
		// Token: 0x06016C92 RID: 93330 RVA: 0x00200AE0 File Offset: 0x001FECE0
		public virtual uint GetMemoryLimit()
		{
			return vtkDicer.vtkDicer_GetMemoryLimit_07(base.GetCppThis());
		}

		// Token: 0x06016C93 RID: 93331
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDicer_GetMemoryLimitMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Control piece size based on a memory limit.  (This ivar has
		/// effect only when the DiceMode is set to
		/// SetDiceModeToMemoryLimit()). The memory limit should be set in
		/// kibibytes (1024 bytes).
		/// </summary>
		// Token: 0x06016C94 RID: 93332 RVA: 0x00200B00 File Offset: 0x001FED00
		public virtual uint GetMemoryLimitMaxValue()
		{
			return vtkDicer.vtkDicer_GetMemoryLimitMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06016C95 RID: 93333
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDicer_GetMemoryLimitMinValue_09(HandleRef pThis);

		/// <summary>
		/// Control piece size based on a memory limit.  (This ivar has
		/// effect only when the DiceMode is set to
		/// SetDiceModeToMemoryLimit()). The memory limit should be set in
		/// kibibytes (1024 bytes).
		/// </summary>
		// Token: 0x06016C96 RID: 93334 RVA: 0x00200B20 File Offset: 0x001FED20
		public virtual uint GetMemoryLimitMinValue()
		{
			return vtkDicer.vtkDicer_GetMemoryLimitMinValue_09(base.GetCppThis());
		}

		// Token: 0x06016C97 RID: 93335
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDicer_GetNumberOfActualPieces_10(HandleRef pThis);

		/// <summary>
		/// Use the following method after the filter has updated to
		/// determine the actual number of pieces the data was separated
		/// into.
		/// </summary>
		// Token: 0x06016C98 RID: 93336 RVA: 0x00200B40 File Offset: 0x001FED40
		public virtual int GetNumberOfActualPieces()
		{
			return vtkDicer.vtkDicer_GetNumberOfActualPieces_10(base.GetCppThis());
		}

		// Token: 0x06016C99 RID: 93337
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDicer_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C9A RID: 93338 RVA: 0x00200B60 File Offset: 0x001FED60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDicer.vtkDicer_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06016C9B RID: 93339
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDicer_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C9C RID: 93340 RVA: 0x00200B80 File Offset: 0x001FED80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDicer.vtkDicer_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06016C9D RID: 93341
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDicer_GetNumberOfPieces_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of pieces the object is to be separated into.
		/// (This ivar has effect only when the DiceMode is set to
		/// SetDiceModeToSpecifiedNumber()). Note that the ivar
		/// NumberOfPieces is a target - depending on the particulars of the
		/// data, more or less number of pieces than the target value may be
		/// created.
		/// </summary>
		// Token: 0x06016C9E RID: 93342 RVA: 0x00200B9C File Offset: 0x001FED9C
		public virtual int GetNumberOfPieces()
		{
			return vtkDicer.vtkDicer_GetNumberOfPieces_13(base.GetCppThis());
		}

		// Token: 0x06016C9F RID: 93343
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDicer_GetNumberOfPiecesMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of pieces the object is to be separated into.
		/// (This ivar has effect only when the DiceMode is set to
		/// SetDiceModeToSpecifiedNumber()). Note that the ivar
		/// NumberOfPieces is a target - depending on the particulars of the
		/// data, more or less number of pieces than the target value may be
		/// created.
		/// </summary>
		// Token: 0x06016CA0 RID: 93344 RVA: 0x00200BBC File Offset: 0x001FEDBC
		public virtual int GetNumberOfPiecesMaxValue()
		{
			return vtkDicer.vtkDicer_GetNumberOfPiecesMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06016CA1 RID: 93345
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDicer_GetNumberOfPiecesMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of pieces the object is to be separated into.
		/// (This ivar has effect only when the DiceMode is set to
		/// SetDiceModeToSpecifiedNumber()). Note that the ivar
		/// NumberOfPieces is a target - depending on the particulars of the
		/// data, more or less number of pieces than the target value may be
		/// created.
		/// </summary>
		// Token: 0x06016CA2 RID: 93346 RVA: 0x00200BDC File Offset: 0x001FEDDC
		public virtual int GetNumberOfPiecesMinValue()
		{
			return vtkDicer.vtkDicer_GetNumberOfPiecesMinValue_15(base.GetCppThis());
		}

		// Token: 0x06016CA3 RID: 93347
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDicer_GetNumberOfPointsPerPiece_16(HandleRef pThis);

		/// <summary>
		/// Control piece size based on the maximum number of points per piece.
		/// (This ivar has effect only when the DiceMode is set to
		/// SetDiceModeToNumberOfPoints().)
		/// </summary>
		// Token: 0x06016CA4 RID: 93348 RVA: 0x00200BFC File Offset: 0x001FEDFC
		public virtual int GetNumberOfPointsPerPiece()
		{
			return vtkDicer.vtkDicer_GetNumberOfPointsPerPiece_16(base.GetCppThis());
		}

		// Token: 0x06016CA5 RID: 93349
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDicer_GetNumberOfPointsPerPieceMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Control piece size based on the maximum number of points per piece.
		/// (This ivar has effect only when the DiceMode is set to
		/// SetDiceModeToNumberOfPoints().)
		/// </summary>
		// Token: 0x06016CA6 RID: 93350 RVA: 0x00200C1C File Offset: 0x001FEE1C
		public virtual int GetNumberOfPointsPerPieceMaxValue()
		{
			return vtkDicer.vtkDicer_GetNumberOfPointsPerPieceMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06016CA7 RID: 93351
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDicer_GetNumberOfPointsPerPieceMinValue_18(HandleRef pThis);

		/// <summary>
		/// Control piece size based on the maximum number of points per piece.
		/// (This ivar has effect only when the DiceMode is set to
		/// SetDiceModeToNumberOfPoints().)
		/// </summary>
		// Token: 0x06016CA8 RID: 93352 RVA: 0x00200C3C File Offset: 0x001FEE3C
		public virtual int GetNumberOfPointsPerPieceMinValue()
		{
			return vtkDicer.vtkDicer_GetNumberOfPointsPerPieceMinValue_18(base.GetCppThis());
		}

		// Token: 0x06016CA9 RID: 93353
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDicer_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016CAA RID: 93354 RVA: 0x00200C5C File Offset: 0x001FEE5C
		public override int IsA(string type)
		{
			return vtkDicer.vtkDicer_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x06016CAB RID: 93355
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDicer_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016CAC RID: 93356 RVA: 0x00200C7C File Offset: 0x001FEE7C
		public new static int IsTypeOf(string type)
		{
			return vtkDicer.vtkDicer_IsTypeOf_20(type);
		}

		// Token: 0x06016CAD RID: 93357
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDicer_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016CAE RID: 93358 RVA: 0x00200C98 File Offset: 0x001FEE98
		public new vtkDicer NewInstance()
		{
			vtkDicer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDicer.vtkDicer_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDicer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016CAF RID: 93359
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDicer_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016CB0 RID: 93360 RVA: 0x00200CF4 File Offset: 0x001FEEF4
		public new static vtkDicer SafeDownCast(vtkObjectBase o)
		{
			vtkDicer vtkDicer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDicer.vtkDicer_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDicer = (vtkDicer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDicer.Register(null);
				}
			}
			return vtkDicer;
		}

		// Token: 0x06016CB1 RID: 93361
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDicer_SetDiceMode_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the method to determine how many pieces the data should be
		/// broken into. By default, the number of points per piece is used.
		/// </summary>
		// Token: 0x06016CB2 RID: 93362 RVA: 0x00200D73 File Offset: 0x001FEF73
		public virtual void SetDiceMode(int _arg)
		{
			vtkDicer.vtkDicer_SetDiceMode_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06016CB3 RID: 93363
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDicer_SetDiceModeToMemoryLimitPerPiece_24(HandleRef pThis);

		/// <summary>
		/// Specify the method to determine how many pieces the data should be
		/// broken into. By default, the number of points per piece is used.
		/// </summary>
		// Token: 0x06016CB4 RID: 93364 RVA: 0x00200D83 File Offset: 0x001FEF83
		public void SetDiceModeToMemoryLimitPerPiece()
		{
			vtkDicer.vtkDicer_SetDiceModeToMemoryLimitPerPiece_24(base.GetCppThis());
		}

		// Token: 0x06016CB5 RID: 93365
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDicer_SetDiceModeToNumberOfPointsPerPiece_25(HandleRef pThis);

		/// <summary>
		/// Specify the method to determine how many pieces the data should be
		/// broken into. By default, the number of points per piece is used.
		/// </summary>
		// Token: 0x06016CB6 RID: 93366 RVA: 0x00200D92 File Offset: 0x001FEF92
		public void SetDiceModeToNumberOfPointsPerPiece()
		{
			vtkDicer.vtkDicer_SetDiceModeToNumberOfPointsPerPiece_25(base.GetCppThis());
		}

		// Token: 0x06016CB7 RID: 93367
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDicer_SetDiceModeToSpecifiedNumberOfPieces_26(HandleRef pThis);

		/// <summary>
		/// Specify the method to determine how many pieces the data should be
		/// broken into. By default, the number of points per piece is used.
		/// </summary>
		// Token: 0x06016CB8 RID: 93368 RVA: 0x00200DA1 File Offset: 0x001FEFA1
		public void SetDiceModeToSpecifiedNumberOfPieces()
		{
			vtkDicer.vtkDicer_SetDiceModeToSpecifiedNumberOfPieces_26(base.GetCppThis());
		}

		// Token: 0x06016CB9 RID: 93369
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDicer_SetFieldData_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag which controls whether to generate point scalar
		/// data or point field data. If this flag is off, scalar data is
		/// generated.  Otherwise, field data is generated. Note that the
		/// generated the data are integer numbers indicating which piece a
		/// particular point belongs to.
		/// </summary>
		// Token: 0x06016CBA RID: 93370 RVA: 0x00200DB0 File Offset: 0x001FEFB0
		public virtual void SetFieldData(int _arg)
		{
			vtkDicer.vtkDicer_SetFieldData_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06016CBB RID: 93371
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDicer_SetMemoryLimit_28(HandleRef pThis, uint _arg);

		/// <summary>
		/// Control piece size based on a memory limit.  (This ivar has
		/// effect only when the DiceMode is set to
		/// SetDiceModeToMemoryLimit()). The memory limit should be set in
		/// kibibytes (1024 bytes).
		/// </summary>
		// Token: 0x06016CBC RID: 93372 RVA: 0x00200DC0 File Offset: 0x001FEFC0
		public virtual void SetMemoryLimit(uint _arg)
		{
			vtkDicer.vtkDicer_SetMemoryLimit_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06016CBD RID: 93373
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDicer_SetNumberOfPieces_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of pieces the object is to be separated into.
		/// (This ivar has effect only when the DiceMode is set to
		/// SetDiceModeToSpecifiedNumber()). Note that the ivar
		/// NumberOfPieces is a target - depending on the particulars of the
		/// data, more or less number of pieces than the target value may be
		/// created.
		/// </summary>
		// Token: 0x06016CBE RID: 93374 RVA: 0x00200DD0 File Offset: 0x001FEFD0
		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkDicer.vtkDicer_SetNumberOfPieces_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06016CBF RID: 93375
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDicer_SetNumberOfPointsPerPiece_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Control piece size based on the maximum number of points per piece.
		/// (This ivar has effect only when the DiceMode is set to
		/// SetDiceModeToNumberOfPoints().)
		/// </summary>
		// Token: 0x06016CC0 RID: 93376 RVA: 0x00200DE0 File Offset: 0x001FEFE0
		public virtual void SetNumberOfPointsPerPiece(int _arg)
		{
			vtkDicer.vtkDicer_SetNumberOfPointsPerPiece_30(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001987 RID: 6535
		public new const string MRFullTypeName = "Kitware.VTK.vtkDicer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001988 RID: 6536
		public new static readonly string MRClassNameKey = "class vtkDicer";
	}
}
