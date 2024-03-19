using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTIFFReader
	/// </summary>
	/// <remarks>
	///    read TIFF files
	///
	/// vtkTIFFReader is a source object that reads TIFF files.
	/// It should be able to read almost any TIFF file
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTIFFWriter
	/// </seealso>
	// Token: 0x0200079A RID: 1946
	public class vtkTIFFReader : vtkImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013FC0 RID: 81856 RVA: 0x001C3A47 File Offset: 0x001C1C47
		static vtkTIFFReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTIFFReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTIFFReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013FC1 RID: 81857 RVA: 0x001C3A6F File Offset: 0x001C1C6F
		public vtkTIFFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013FC2 RID: 81858
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTIFFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FC3 RID: 81859 RVA: 0x001C3A80 File Offset: 0x001C1C80
		public new static vtkTIFFReader New()
		{
			vtkTIFFReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTIFFReader.vtkTIFFReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTIFFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FC4 RID: 81860 RVA: 0x001C3AD4 File Offset: 0x001C1CD4
		public vtkTIFFReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTIFFReader.vtkTIFFReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013FC5 RID: 81861 RVA: 0x001C3B18 File Offset: 0x001C1D18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013FC6 RID: 81862
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTIFFReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Is the given file name a tiff file?
		/// </summary>
		// Token: 0x06013FC7 RID: 81863 RVA: 0x001C3B24 File Offset: 0x001C1D24
		public override int CanReadFile(string fname)
		{
			return vtkTIFFReader.vtkTIFFReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		// Token: 0x06013FC8 RID: 81864
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTIFFReader_GetDescriptiveName_02(HandleRef pThis);

		/// <summary>
		/// Return a descriptive name for the file format that might be useful
		/// in a GUI.
		/// </summary>
		// Token: 0x06013FC9 RID: 81865 RVA: 0x001C3B44 File Offset: 0x001C1D44
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTIFFReader.vtkTIFFReader_GetDescriptiveName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013FCA RID: 81866
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTIFFReader_GetFileExtensions_03(HandleRef pThis);

		/// <summary>
		/// Get the file extensions for this format.
		/// Returns a string with a space separated list of extensions in
		/// the format .extension
		/// </summary>
		// Token: 0x06013FCB RID: 81867 RVA: 0x001C3B80 File Offset: 0x001C1D80
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkTIFFReader.vtkTIFFReader_GetFileExtensions_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013FCC RID: 81868
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTIFFReader_GetIgnoreColorMap_04(HandleRef pThis);

		/// <summary>
		/// When set to true (default false), TIFFTAG_COLORMAP, if any, will be
		/// ignored.
		/// </summary>
		// Token: 0x06013FCD RID: 81869 RVA: 0x001C3BBC File Offset: 0x001C1DBC
		public virtual bool GetIgnoreColorMap()
		{
			return vtkTIFFReader.vtkTIFFReader_GetIgnoreColorMap_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06013FCE RID: 81870
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTIFFReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FCF RID: 81871 RVA: 0x001C3BE4 File Offset: 0x001C1DE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTIFFReader.vtkTIFFReader_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06013FD0 RID: 81872
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTIFFReader_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FD1 RID: 81873 RVA: 0x001C3C04 File Offset: 0x001C1E04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTIFFReader.vtkTIFFReader_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06013FD2 RID: 81874
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkTIFFReader_GetOrientationType_07(HandleRef pThis);

		/// <summary>
		/// Set orientation type
		/// ORIENTATION_TOPLEFT         1       (row 0 top, col 0 lhs)
		/// ORIENTATION_TOPRIGHT        2       (row 0 top, col 0 rhs)
		/// ORIENTATION_BOTRIGHT        3       (row 0 bottom, col 0 rhs)
		/// ORIENTATION_BOTLEFT         4       (row 0 bottom, col 0 lhs)
		/// ORIENTATION_LEFTTOP         5       (row 0 lhs, col 0 top)
		/// ORIENTATION_RIGHTTOP        6       (row 0 rhs, col 0 top)
		/// ORIENTATION_RIGHTBOT        7       (row 0 rhs, col 0 bottom)
		/// ORIENTATION_LEFTBOT         8       (row 0 lhs, col 0 bottom)
		/// User need to explicitly include vtk_tiff.h header to have access to those these macros
		/// </summary>
		// Token: 0x06013FD3 RID: 81875 RVA: 0x001C3C20 File Offset: 0x001C1E20
		public virtual uint GetOrientationType()
		{
			return vtkTIFFReader.vtkTIFFReader_GetOrientationType_07(base.GetCppThis());
		}

		// Token: 0x06013FD4 RID: 81876
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTIFFReader_GetOrientationTypeSpecifiedFlag_08(HandleRef pThis);

		/// <summary>
		/// Get method to check if orientation type is specified.
		/// </summary>
		// Token: 0x06013FD5 RID: 81877 RVA: 0x001C3C40 File Offset: 0x001C1E40
		public virtual bool GetOrientationTypeSpecifiedFlag()
		{
			return vtkTIFFReader.vtkTIFFReader_GetOrientationTypeSpecifiedFlag_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06013FD6 RID: 81878
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTIFFReader_GetOriginSpecifiedFlag_09(HandleRef pThis);

		/// <summary>
		/// Set/get methods to see if manual origin has been set.
		/// </summary>
		// Token: 0x06013FD7 RID: 81879 RVA: 0x001C3C68 File Offset: 0x001C1E68
		public virtual bool GetOriginSpecifiedFlag()
		{
			return vtkTIFFReader.vtkTIFFReader_GetOriginSpecifiedFlag_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06013FD8 RID: 81880
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTIFFReader_GetSpacingSpecifiedFlag_10(HandleRef pThis);

		/// <summary>
		/// Set/get if the spacing flag has been specified.
		/// </summary>
		// Token: 0x06013FD9 RID: 81881 RVA: 0x001C3C90 File Offset: 0x001C1E90
		public virtual bool GetSpacingSpecifiedFlag()
		{
			return vtkTIFFReader.vtkTIFFReader_GetSpacingSpecifiedFlag_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06013FDA RID: 81882
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFReader_IgnoreColorMapOff_11(HandleRef pThis);

		/// <summary>
		/// When set to true (default false), TIFFTAG_COLORMAP, if any, will be
		/// ignored.
		/// </summary>
		// Token: 0x06013FDB RID: 81883 RVA: 0x001C3CB6 File Offset: 0x001C1EB6
		public virtual void IgnoreColorMapOff()
		{
			vtkTIFFReader.vtkTIFFReader_IgnoreColorMapOff_11(base.GetCppThis());
		}

		// Token: 0x06013FDC RID: 81884
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFReader_IgnoreColorMapOn_12(HandleRef pThis);

		/// <summary>
		/// When set to true (default false), TIFFTAG_COLORMAP, if any, will be
		/// ignored.
		/// </summary>
		// Token: 0x06013FDD RID: 81885 RVA: 0x001C3CC5 File Offset: 0x001C1EC5
		public virtual void IgnoreColorMapOn()
		{
			vtkTIFFReader.vtkTIFFReader_IgnoreColorMapOn_12(base.GetCppThis());
		}

		// Token: 0x06013FDE RID: 81886
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTIFFReader_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FDF RID: 81887 RVA: 0x001C3CD4 File Offset: 0x001C1ED4
		public override int IsA(string type)
		{
			return vtkTIFFReader.vtkTIFFReader_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06013FE0 RID: 81888
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTIFFReader_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FE1 RID: 81889 RVA: 0x001C3CF4 File Offset: 0x001C1EF4
		public new static int IsTypeOf(string type)
		{
			return vtkTIFFReader.vtkTIFFReader_IsTypeOf_14(type);
		}

		// Token: 0x06013FE2 RID: 81890
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTIFFReader_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FE3 RID: 81891 RVA: 0x001C3D10 File Offset: 0x001C1F10
		public new vtkTIFFReader NewInstance()
		{
			vtkTIFFReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTIFFReader.vtkTIFFReader_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTIFFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013FE4 RID: 81892
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFReader_OriginSpecifiedFlagOff_17(HandleRef pThis);

		/// <summary>
		/// Set/get methods to see if manual origin has been set.
		/// </summary>
		// Token: 0x06013FE5 RID: 81893 RVA: 0x001C3D6A File Offset: 0x001C1F6A
		public virtual void OriginSpecifiedFlagOff()
		{
			vtkTIFFReader.vtkTIFFReader_OriginSpecifiedFlagOff_17(base.GetCppThis());
		}

		// Token: 0x06013FE6 RID: 81894
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFReader_OriginSpecifiedFlagOn_18(HandleRef pThis);

		/// <summary>
		/// Set/get methods to see if manual origin has been set.
		/// </summary>
		// Token: 0x06013FE7 RID: 81895 RVA: 0x001C3D79 File Offset: 0x001C1F79
		public virtual void OriginSpecifiedFlagOn()
		{
			vtkTIFFReader.vtkTIFFReader_OriginSpecifiedFlagOn_18(base.GetCppThis());
		}

		// Token: 0x06013FE8 RID: 81896
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTIFFReader_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FE9 RID: 81897 RVA: 0x001C3D88 File Offset: 0x001C1F88
		public new static vtkTIFFReader SafeDownCast(vtkObjectBase o)
		{
			vtkTIFFReader vtkTIFFReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTIFFReader.vtkTIFFReader_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTIFFReader = (vtkTIFFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTIFFReader.Register(null);
				}
			}
			return vtkTIFFReader;
		}

		// Token: 0x06013FEA RID: 81898
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFReader_SetIgnoreColorMap_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default false), TIFFTAG_COLORMAP, if any, will be
		/// ignored.
		/// </summary>
		// Token: 0x06013FEB RID: 81899 RVA: 0x001C3E07 File Offset: 0x001C2007
		public virtual void SetIgnoreColorMap(bool _arg)
		{
			vtkTIFFReader.vtkTIFFReader_SetIgnoreColorMap_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06013FEC RID: 81900
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFReader_SetOrientationType_21(HandleRef pThis, uint orientationType);

		/// <summary>
		/// Set orientation type
		/// ORIENTATION_TOPLEFT         1       (row 0 top, col 0 lhs)
		/// ORIENTATION_TOPRIGHT        2       (row 0 top, col 0 rhs)
		/// ORIENTATION_BOTRIGHT        3       (row 0 bottom, col 0 rhs)
		/// ORIENTATION_BOTLEFT         4       (row 0 bottom, col 0 lhs)
		/// ORIENTATION_LEFTTOP         5       (row 0 lhs, col 0 top)
		/// ORIENTATION_RIGHTTOP        6       (row 0 rhs, col 0 top)
		/// ORIENTATION_RIGHTBOT        7       (row 0 rhs, col 0 bottom)
		/// ORIENTATION_LEFTBOT         8       (row 0 lhs, col 0 bottom)
		/// User need to explicitly include vtk_tiff.h header to have access to those these macros
		/// </summary>
		// Token: 0x06013FED RID: 81901 RVA: 0x001C3E1F File Offset: 0x001C201F
		public void SetOrientationType(uint orientationType)
		{
			vtkTIFFReader.vtkTIFFReader_SetOrientationType_21(base.GetCppThis(), orientationType);
		}

		// Token: 0x06013FEE RID: 81902
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFReader_SetOriginSpecifiedFlag_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get methods to see if manual origin has been set.
		/// </summary>
		// Token: 0x06013FEF RID: 81903 RVA: 0x001C3E2F File Offset: 0x001C202F
		public virtual void SetOriginSpecifiedFlag(bool _arg)
		{
			vtkTIFFReader.vtkTIFFReader_SetOriginSpecifiedFlag_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06013FF0 RID: 81904
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFReader_SetSpacingSpecifiedFlag_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get if the spacing flag has been specified.
		/// </summary>
		// Token: 0x06013FF1 RID: 81905 RVA: 0x001C3E47 File Offset: 0x001C2047
		public virtual void SetSpacingSpecifiedFlag(bool _arg)
		{
			vtkTIFFReader.vtkTIFFReader_SetSpacingSpecifiedFlag_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06013FF2 RID: 81906
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFReader_SpacingSpecifiedFlagOff_24(HandleRef pThis);

		/// <summary>
		/// Set/get if the spacing flag has been specified.
		/// </summary>
		// Token: 0x06013FF3 RID: 81907 RVA: 0x001C3E5F File Offset: 0x001C205F
		public virtual void SpacingSpecifiedFlagOff()
		{
			vtkTIFFReader.vtkTIFFReader_SpacingSpecifiedFlagOff_24(base.GetCppThis());
		}

		// Token: 0x06013FF4 RID: 81908
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFReader_SpacingSpecifiedFlagOn_25(HandleRef pThis);

		/// <summary>
		/// Set/get if the spacing flag has been specified.
		/// </summary>
		// Token: 0x06013FF5 RID: 81909 RVA: 0x001C3E6E File Offset: 0x001C206E
		public virtual void SpacingSpecifiedFlagOn()
		{
			vtkTIFFReader.vtkTIFFReader_SpacingSpecifiedFlagOn_25(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001734 RID: 5940
		public new const string MRFullTypeName = "Kitware.VTK.vtkTIFFReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001735 RID: 5941
		public new static readonly string MRClassNameKey = "class vtkTIFFReader";
	}
}
