using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkSegYReader
	/// </summary>
	/// <remarks>
	///  Reads SegY data files.
	///
	/// vtkSegYReader reads SegY data files. We create a vtkStructuredGrid
	/// for 2.5D SegY and 3D data. If we set the StructuredGrid option to 0
	/// we create a vtkImageData for 3D data. This saves memory and may
	/// speed-up certain algorithms, but the position and the shape of the
	/// data may not be correct. The axes for the data are: crossline,
	/// inline, depth. For situations where traces are missing values of
	/// zero are used to fill in the dataset.
	/// </remarks>
	// Token: 0x02000130 RID: 304
	public class vtkSegYReader : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003D39 RID: 15673 RVA: 0x00059920 File Offset: 0x00057B20
		static vtkSegYReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSegYReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSegYReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003D3A RID: 15674 RVA: 0x00059948 File Offset: 0x00057B48
		public vtkSegYReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003D3B RID: 15675
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSegYReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D3C RID: 15676 RVA: 0x00059958 File Offset: 0x00057B58
		public new static vtkSegYReader New()
		{
			vtkSegYReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSegYReader.vtkSegYReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSegYReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D3D RID: 15677 RVA: 0x000599AC File Offset: 0x00057BAC
		public vtkSegYReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSegYReader.vtkSegYReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003D3E RID: 15678 RVA: 0x000599F0 File Offset: 0x00057BF0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003D3F RID: 15679
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSegYReader_Force2DOff_01(HandleRef pThis);

		/// <summary>
		/// Should we force the data to be interpreted as a 2D dataset? It may be a
		/// 2D sheet through 3D space. When this is turned on we ignore the cross
		/// line and line values and instead build a 2D data by processing and
		/// connecting the traces in order from first to last. The output will be a
		/// Structrured Grid.
		/// </summary>
		// Token: 0x06003D40 RID: 15680 RVA: 0x000599FB File Offset: 0x00057BFB
		public virtual void Force2DOff()
		{
			vtkSegYReader.vtkSegYReader_Force2DOff_01(base.GetCppThis());
		}

		// Token: 0x06003D41 RID: 15681
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSegYReader_Force2DOn_02(HandleRef pThis);

		/// <summary>
		/// Should we force the data to be interpreted as a 2D dataset? It may be a
		/// 2D sheet through 3D space. When this is turned on we ignore the cross
		/// line and line values and instead build a 2D data by processing and
		/// connecting the traces in order from first to last. The output will be a
		/// Structrured Grid.
		/// </summary>
		// Token: 0x06003D42 RID: 15682 RVA: 0x00059A0A File Offset: 0x00057C0A
		public virtual void Force2DOn()
		{
			vtkSegYReader.vtkSegYReader_Force2DOn_02(base.GetCppThis());
		}

		// Token: 0x06003D43 RID: 15683
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSegYReader_GetFileName_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D44 RID: 15684 RVA: 0x00059A1C File Offset: 0x00057C1C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSegYReader.vtkSegYReader_GetFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003D45 RID: 15685
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSegYReader_GetForce2D_04(HandleRef pThis);

		/// <summary>
		/// Should we force the data to be interpreted as a 2D dataset? It may be a
		/// 2D sheet through 3D space. When this is turned on we ignore the cross
		/// line and line values and instead build a 2D data by processing and
		/// connecting the traces in order from first to last. The output will be a
		/// Structrured Grid.
		/// </summary>
		// Token: 0x06003D46 RID: 15686 RVA: 0x00059A58 File Offset: 0x00057C58
		public virtual bool GetForce2D()
		{
			return vtkSegYReader.vtkSegYReader_GetForce2D_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06003D47 RID: 15687
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSegYReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D48 RID: 15688 RVA: 0x00059A80 File Offset: 0x00057C80
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSegYReader.vtkSegYReader_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06003D49 RID: 15689
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSegYReader_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D4A RID: 15690 RVA: 0x00059AA0 File Offset: 0x00057CA0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSegYReader.vtkSegYReader_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06003D4B RID: 15691
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSegYReader_GetStructuredGrid_07(HandleRef pThis);

		/// <summary>
		/// Specify if we create a vtkStructuredGrid even when the data is
		/// 3D. Note this consumes more memory but it shows the precise
		/// location for each point and the correct shape of the data. The
		/// default value is true.  If we set this option to false we
		/// create a vtkImageData for the SegY 3D dataset.
		/// </summary>
		// Token: 0x06003D4C RID: 15692 RVA: 0x00059ABC File Offset: 0x00057CBC
		public virtual int GetStructuredGrid()
		{
			return vtkSegYReader.vtkSegYReader_GetStructuredGrid_07(base.GetCppThis());
		}

		// Token: 0x06003D4D RID: 15693
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSegYReader_GetVerticalCRS_08(HandleRef pThis);

		/// <summary>
		/// Specify whether the vertical coordinates in the SEG-Y file are heights
		/// (positive up) or depths (positive down). By default, the vertical
		/// coordinates are treated as heights (i.e. positive up). This means that the
		/// Z-axis of the dataset goes from 0 (surface) to -ve depth (last sample).
		/// \note As per the SEG-Y rev 2.0 specification, this information is defined
		/// in the Location Data Stanza of the Extended Textual Header. However, as of
		/// this revision, vtkSegY2DReader does not support reading the extended
		/// textual header.
		/// </summary>
		// Token: 0x06003D4E RID: 15694 RVA: 0x00059ADC File Offset: 0x00057CDC
		public virtual int GetVerticalCRS()
		{
			return vtkSegYReader.vtkSegYReader_GetVerticalCRS_08(base.GetCppThis());
		}

		// Token: 0x06003D4F RID: 15695
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSegYReader_GetXCoordByte_09(HandleRef pThis);

		/// <summary>
		/// Specify X and Y byte positions for custom XYCoordinateMode.
		/// By default, XCoordByte = 73, YCoordByte = 77 i.e. source xy.
		///
		/// \sa SetXYCoordinatesModeToCustom()
		/// </summary>
		// Token: 0x06003D50 RID: 15696 RVA: 0x00059AFC File Offset: 0x00057CFC
		public virtual int GetXCoordByte()
		{
			return vtkSegYReader.vtkSegYReader_GetXCoordByte_09(base.GetCppThis());
		}

		// Token: 0x06003D51 RID: 15697
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSegYReader_GetXYCoordMode_10(HandleRef pThis);

		/// <summary>
		/// Specify whether to use source x/y coordinates or CDP coordinates or custom
		/// byte positions for data position in the SEG-Y trace header. Defaults to
		/// source x/y coordinates.
		///
		/// As per SEG-Y rev 2.0 specification,
		/// Source XY coordinate bytes = (73, 77)
		/// CDP XY coordinate bytes = (181, 185)
		/// </summary>
		// Token: 0x06003D52 RID: 15698 RVA: 0x00059B1C File Offset: 0x00057D1C
		public virtual int GetXYCoordMode()
		{
			return vtkSegYReader.vtkSegYReader_GetXYCoordMode_10(base.GetCppThis());
		}

		// Token: 0x06003D53 RID: 15699
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSegYReader_GetXYCoordModeMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Specify whether to use source x/y coordinates or CDP coordinates or custom
		/// byte positions for data position in the SEG-Y trace header. Defaults to
		/// source x/y coordinates.
		///
		/// As per SEG-Y rev 2.0 specification,
		/// Source XY coordinate bytes = (73, 77)
		/// CDP XY coordinate bytes = (181, 185)
		/// </summary>
		// Token: 0x06003D54 RID: 15700 RVA: 0x00059B3C File Offset: 0x00057D3C
		public virtual int GetXYCoordModeMaxValue()
		{
			return vtkSegYReader.vtkSegYReader_GetXYCoordModeMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06003D55 RID: 15701
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSegYReader_GetXYCoordModeMinValue_12(HandleRef pThis);

		/// <summary>
		/// Specify whether to use source x/y coordinates or CDP coordinates or custom
		/// byte positions for data position in the SEG-Y trace header. Defaults to
		/// source x/y coordinates.
		///
		/// As per SEG-Y rev 2.0 specification,
		/// Source XY coordinate bytes = (73, 77)
		/// CDP XY coordinate bytes = (181, 185)
		/// </summary>
		// Token: 0x06003D56 RID: 15702 RVA: 0x00059B5C File Offset: 0x00057D5C
		public virtual int GetXYCoordModeMinValue()
		{
			return vtkSegYReader.vtkSegYReader_GetXYCoordModeMinValue_12(base.GetCppThis());
		}

		// Token: 0x06003D57 RID: 15703
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSegYReader_GetYCoordByte_13(HandleRef pThis);

		/// <summary>
		/// Specify X and Y byte positions for custom XYCoordinateMode.
		/// By default, XCoordByte = 73, YCoordByte = 77 i.e. source xy.
		///
		/// \sa SetXYCoordinatesModeToCustom()
		/// </summary>
		// Token: 0x06003D58 RID: 15704 RVA: 0x00059B7C File Offset: 0x00057D7C
		public virtual int GetYCoordByte()
		{
			return vtkSegYReader.vtkSegYReader_GetYCoordByte_13(base.GetCppThis());
		}

		// Token: 0x06003D59 RID: 15705
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSegYReader_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D5A RID: 15706 RVA: 0x00059B9C File Offset: 0x00057D9C
		public override int IsA(string type)
		{
			return vtkSegYReader.vtkSegYReader_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06003D5B RID: 15707
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSegYReader_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D5C RID: 15708 RVA: 0x00059BBC File Offset: 0x00057DBC
		public new static int IsTypeOf(string type)
		{
			return vtkSegYReader.vtkSegYReader_IsTypeOf_15(type);
		}

		// Token: 0x06003D5D RID: 15709
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSegYReader_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D5E RID: 15710 RVA: 0x00059BD8 File Offset: 0x00057DD8
		public new vtkSegYReader NewInstance()
		{
			vtkSegYReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSegYReader.vtkSegYReader_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSegYReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003D5F RID: 15711
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSegYReader_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D60 RID: 15712 RVA: 0x00059C34 File Offset: 0x00057E34
		public new static vtkSegYReader SafeDownCast(vtkObjectBase o)
		{
			vtkSegYReader vtkSegYReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSegYReader.vtkSegYReader_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSegYReader = (vtkSegYReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSegYReader.Register(null);
				}
			}
			return vtkSegYReader;
		}

		// Token: 0x06003D61 RID: 15713
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSegYReader_SetFileName_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D62 RID: 15714 RVA: 0x00059CB3 File Offset: 0x00057EB3
		public virtual void SetFileName(string _arg)
		{
			vtkSegYReader.vtkSegYReader_SetFileName_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06003D63 RID: 15715
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSegYReader_SetForce2D_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// Should we force the data to be interpreted as a 2D dataset? It may be a
		/// 2D sheet through 3D space. When this is turned on we ignore the cross
		/// line and line values and instead build a 2D data by processing and
		/// connecting the traces in order from first to last. The output will be a
		/// Structrured Grid.
		/// </summary>
		// Token: 0x06003D64 RID: 15716 RVA: 0x00059CC3 File Offset: 0x00057EC3
		public virtual void SetForce2D(bool _arg)
		{
			vtkSegYReader.vtkSegYReader_SetForce2D_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06003D65 RID: 15717
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSegYReader_SetStructuredGrid_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify if we create a vtkStructuredGrid even when the data is
		/// 3D. Note this consumes more memory but it shows the precise
		/// location for each point and the correct shape of the data. The
		/// default value is true.  If we set this option to false we
		/// create a vtkImageData for the SegY 3D dataset.
		/// </summary>
		// Token: 0x06003D66 RID: 15718 RVA: 0x00059CDB File Offset: 0x00057EDB
		public virtual void SetStructuredGrid(int _arg)
		{
			vtkSegYReader.vtkSegYReader_SetStructuredGrid_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06003D67 RID: 15719
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSegYReader_SetVerticalCRS_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether the vertical coordinates in the SEG-Y file are heights
		/// (positive up) or depths (positive down). By default, the vertical
		/// coordinates are treated as heights (i.e. positive up). This means that the
		/// Z-axis of the dataset goes from 0 (surface) to -ve depth (last sample).
		/// \note As per the SEG-Y rev 2.0 specification, this information is defined
		/// in the Location Data Stanza of the Extended Textual Header. However, as of
		/// this revision, vtkSegY2DReader does not support reading the extended
		/// textual header.
		/// </summary>
		// Token: 0x06003D68 RID: 15720 RVA: 0x00059CEB File Offset: 0x00057EEB
		public virtual void SetVerticalCRS(int _arg)
		{
			vtkSegYReader.vtkSegYReader_SetVerticalCRS_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06003D69 RID: 15721
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSegYReader_SetXCoordByte_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify X and Y byte positions for custom XYCoordinateMode.
		/// By default, XCoordByte = 73, YCoordByte = 77 i.e. source xy.
		///
		/// \sa SetXYCoordinatesModeToCustom()
		/// </summary>
		// Token: 0x06003D6A RID: 15722 RVA: 0x00059CFB File Offset: 0x00057EFB
		public virtual void SetXCoordByte(int _arg)
		{
			vtkSegYReader.vtkSegYReader_SetXCoordByte_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06003D6B RID: 15723
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSegYReader_SetXYCoordMode_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to use source x/y coordinates or CDP coordinates or custom
		/// byte positions for data position in the SEG-Y trace header. Defaults to
		/// source x/y coordinates.
		///
		/// As per SEG-Y rev 2.0 specification,
		/// Source XY coordinate bytes = (73, 77)
		/// CDP XY coordinate bytes = (181, 185)
		/// </summary>
		// Token: 0x06003D6C RID: 15724 RVA: 0x00059D0B File Offset: 0x00057F0B
		public virtual void SetXYCoordMode(int _arg)
		{
			vtkSegYReader.vtkSegYReader_SetXYCoordMode_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06003D6D RID: 15725
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSegYReader_SetXYCoordModeToCDP_25(HandleRef pThis);

		/// <summary>
		/// Specify whether to use source x/y coordinates or CDP coordinates or custom
		/// byte positions for data position in the SEG-Y trace header. Defaults to
		/// source x/y coordinates.
		///
		/// As per SEG-Y rev 2.0 specification,
		/// Source XY coordinate bytes = (73, 77)
		/// CDP XY coordinate bytes = (181, 185)
		/// </summary>
		// Token: 0x06003D6E RID: 15726 RVA: 0x00059D1B File Offset: 0x00057F1B
		public void SetXYCoordModeToCDP()
		{
			vtkSegYReader.vtkSegYReader_SetXYCoordModeToCDP_25(base.GetCppThis());
		}

		// Token: 0x06003D6F RID: 15727
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSegYReader_SetXYCoordModeToCustom_26(HandleRef pThis);

		/// <summary>
		/// Specify whether to use source x/y coordinates or CDP coordinates or custom
		/// byte positions for data position in the SEG-Y trace header. Defaults to
		/// source x/y coordinates.
		///
		/// As per SEG-Y rev 2.0 specification,
		/// Source XY coordinate bytes = (73, 77)
		/// CDP XY coordinate bytes = (181, 185)
		/// </summary>
		// Token: 0x06003D70 RID: 15728 RVA: 0x00059D2A File Offset: 0x00057F2A
		public void SetXYCoordModeToCustom()
		{
			vtkSegYReader.vtkSegYReader_SetXYCoordModeToCustom_26(base.GetCppThis());
		}

		// Token: 0x06003D71 RID: 15729
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSegYReader_SetXYCoordModeToSource_27(HandleRef pThis);

		/// <summary>
		/// Specify whether to use source x/y coordinates or CDP coordinates or custom
		/// byte positions for data position in the SEG-Y trace header. Defaults to
		/// source x/y coordinates.
		///
		/// As per SEG-Y rev 2.0 specification,
		/// Source XY coordinate bytes = (73, 77)
		/// CDP XY coordinate bytes = (181, 185)
		/// </summary>
		// Token: 0x06003D72 RID: 15730 RVA: 0x00059D39 File Offset: 0x00057F39
		public void SetXYCoordModeToSource()
		{
			vtkSegYReader.vtkSegYReader_SetXYCoordModeToSource_27(base.GetCppThis());
		}

		// Token: 0x06003D73 RID: 15731
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSegYReader_SetYCoordByte_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify X and Y byte positions for custom XYCoordinateMode.
		/// By default, XCoordByte = 73, YCoordByte = 77 i.e. source xy.
		///
		/// \sa SetXYCoordinatesModeToCustom()
		/// </summary>
		// Token: 0x06003D74 RID: 15732 RVA: 0x00059D48 File Offset: 0x00057F48
		public virtual void SetYCoordByte(int _arg)
		{
			vtkSegYReader.vtkSegYReader_SetYCoordByte_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06003D75 RID: 15733
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSegYReader_StructuredGridOff_29(HandleRef pThis);

		/// <summary>
		/// Specify if we create a vtkStructuredGrid even when the data is
		/// 3D. Note this consumes more memory but it shows the precise
		/// location for each point and the correct shape of the data. The
		/// default value is true.  If we set this option to false we
		/// create a vtkImageData for the SegY 3D dataset.
		/// </summary>
		// Token: 0x06003D76 RID: 15734 RVA: 0x00059D58 File Offset: 0x00057F58
		public virtual void StructuredGridOff()
		{
			vtkSegYReader.vtkSegYReader_StructuredGridOff_29(base.GetCppThis());
		}

		// Token: 0x06003D77 RID: 15735
		[DllImport("Kitware.VTK.IOSegY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSegYReader_StructuredGridOn_30(HandleRef pThis);

		/// <summary>
		/// Specify if we create a vtkStructuredGrid even when the data is
		/// 3D. Note this consumes more memory but it shows the precise
		/// location for each point and the correct shape of the data. The
		/// default value is true.  If we set this option to false we
		/// create a vtkImageData for the SegY 3D dataset.
		/// </summary>
		// Token: 0x06003D78 RID: 15736 RVA: 0x00059D67 File Offset: 0x00057F67
		public virtual void StructuredGridOn()
		{
			vtkSegYReader.vtkSegYReader_StructuredGridOn_30(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000699 RID: 1689
		public new const string MRFullTypeName = "Kitware.VTK.vtkSegYReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400069A RID: 1690
		public new static readonly string MRClassNameKey = "class vtkSegYReader";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000131 RID: 305
		public enum VTKSegYCoordinateModes
		{
			/// <summary>enum member</summary>
			// Token: 0x0400069C RID: 1692
			VTK_SEGY_CDP = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400069D RID: 1693
			VTK_SEGY_CUSTOM,
			/// <summary>enum member</summary>
			// Token: 0x0400069E RID: 1694
			VTK_SEGY_SOURCE = 0
		}

		/// <summary>
		/// Specify X and Y byte positions for custom XYCoordinateMode.
		/// By default, XCoordByte = 73, YCoordByte = 77 i.e. source xy.
		///
		/// \sa SetXYCoordinatesModeToCustom()
		/// </summary>
		// Token: 0x02000132 RID: 306
		public enum VTKSegYVerticalCRS
		{
			/// <summary>enum member</summary>
			// Token: 0x040006A0 RID: 1696
			VTK_SEGY_VERTICAL_DEPTHS = 1,
			/// <summary>enum member</summary>
			// Token: 0x040006A1 RID: 1697
			VTK_SEGY_VERTICAL_HEIGHTS = 0
		}
	}
}
