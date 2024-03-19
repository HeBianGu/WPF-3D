using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSTLWriter
	/// </summary>
	/// <remarks>
	///    write stereo lithography files
	///
	/// vtkSTLWriter writes stereo lithography (.stl) files in either ASCII or
	/// binary form. Stereo lithography files contain only triangles. Since VTK 8.1,
	/// this writer converts non-triangle polygons into triangles, so there is no
	/// longer a need to use vtkTriangleFilter prior to using this writer if the
	/// input contains polygons with more than three vertices.
	///
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// vtkSTLWriter uses VAX or PC byte ordering and swaps bytes on other systems.
	/// </remarks>
	// Token: 0x02000213 RID: 531
	public class vtkSTLWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600652E RID: 25902 RVA: 0x0009180F File Offset: 0x0008FA0F
		static vtkSTLWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSTLWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSTLWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600652F RID: 25903 RVA: 0x00091837 File Offset: 0x0008FA37
		public vtkSTLWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006530 RID: 25904
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSTLWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006531 RID: 25905 RVA: 0x00091848 File Offset: 0x0008FA48
		public new static vtkSTLWriter New()
		{
			vtkSTLWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSTLWriter.vtkSTLWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSTLWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006532 RID: 25906 RVA: 0x0009189C File Offset: 0x0008FA9C
		public vtkSTLWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSTLWriter.vtkSTLWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006533 RID: 25907 RVA: 0x000918E0 File Offset: 0x0008FAE0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006534 RID: 25908
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSTLWriter_GetBinaryHeader_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set binary header for the file.
		/// Binary header is only used when writing binary type files.
		/// If both Header and BinaryHeader are specified then BinaryHeader is used.
		/// Maximum length of binary header is 80 bytes, any content over this limit is ignored.
		/// </summary>
		// Token: 0x06006535 RID: 25909 RVA: 0x000918EC File Offset: 0x0008FAEC
		public virtual vtkUnsignedCharArray GetBinaryHeader()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSTLWriter.vtkSTLWriter_GetBinaryHeader_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x06006536 RID: 25910
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSTLWriter_GetFileName_02(HandleRef pThis);

		/// <summary>
		/// Specify file name of vtk polygon data file to write.
		/// </summary>
		// Token: 0x06006537 RID: 25911 RVA: 0x0009195C File Offset: 0x0008FB5C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSTLWriter.vtkSTLWriter_GetFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006538 RID: 25912
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSTLWriter_GetFileType_03(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x06006539 RID: 25913 RVA: 0x00091998 File Offset: 0x0008FB98
		public virtual int GetFileType()
		{
			return vtkSTLWriter.vtkSTLWriter_GetFileType_03(base.GetCppThis());
		}

		// Token: 0x0600653A RID: 25914
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSTLWriter_GetFileTypeMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x0600653B RID: 25915 RVA: 0x000919B8 File Offset: 0x0008FBB8
		public virtual int GetFileTypeMaxValue()
		{
			return vtkSTLWriter.vtkSTLWriter_GetFileTypeMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0600653C RID: 25916
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSTLWriter_GetFileTypeMinValue_05(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x0600653D RID: 25917 RVA: 0x000919D8 File Offset: 0x0008FBD8
		public virtual int GetFileTypeMinValue()
		{
			return vtkSTLWriter.vtkSTLWriter_GetFileTypeMinValue_05(base.GetCppThis());
		}

		// Token: 0x0600653E RID: 25918
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSTLWriter_GetHeader_06(HandleRef pThis);

		/// <summary>
		/// Set the header for the file as text. The header cannot contain 0x00 characters.
		/// \sa SetBinaryHeader()
		/// </summary>
		// Token: 0x0600653F RID: 25919 RVA: 0x000919F8 File Offset: 0x0008FBF8
		public virtual string GetHeader()
		{
			string s = Marshal.PtrToStringAnsi(vtkSTLWriter.vtkSTLWriter_GetHeader_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006540 RID: 25920
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSTLWriter_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06006541 RID: 25921 RVA: 0x00091A34 File Offset: 0x0008FC34
		public new vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSTLWriter.vtkSTLWriter_GetInput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06006542 RID: 25922
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSTLWriter_GetInput_08(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06006543 RID: 25923 RVA: 0x00091AA4 File Offset: 0x0008FCA4
		public new vtkPolyData GetInput(int port)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSTLWriter.vtkSTLWriter_GetInput_08(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06006544 RID: 25924
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSTLWriter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006545 RID: 25925 RVA: 0x00091B14 File Offset: 0x0008FD14
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSTLWriter.vtkSTLWriter_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06006546 RID: 25926
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSTLWriter_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006547 RID: 25927 RVA: 0x00091B34 File Offset: 0x0008FD34
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSTLWriter.vtkSTLWriter_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06006548 RID: 25928
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSTLWriter_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006549 RID: 25929 RVA: 0x00091B50 File Offset: 0x0008FD50
		public override int IsA(string type)
		{
			return vtkSTLWriter.vtkSTLWriter_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600654A RID: 25930
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSTLWriter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600654B RID: 25931 RVA: 0x00091B70 File Offset: 0x0008FD70
		public new static int IsTypeOf(string type)
		{
			return vtkSTLWriter.vtkSTLWriter_IsTypeOf_12(type);
		}

		// Token: 0x0600654C RID: 25932
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSTLWriter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600654D RID: 25933 RVA: 0x00091B8C File Offset: 0x0008FD8C
		public new vtkSTLWriter NewInstance()
		{
			vtkSTLWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSTLWriter.vtkSTLWriter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSTLWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600654E RID: 25934
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSTLWriter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600654F RID: 25935 RVA: 0x00091BE8 File Offset: 0x0008FDE8
		public new static vtkSTLWriter SafeDownCast(vtkObjectBase o)
		{
			vtkSTLWriter vtkSTLWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSTLWriter.vtkSTLWriter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSTLWriter = (vtkSTLWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSTLWriter.Register(null);
				}
			}
			return vtkSTLWriter;
		}

		// Token: 0x06006550 RID: 25936
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSTLWriter_SetBinaryHeader_16(HandleRef pThis, HandleRef binaryHeader);

		/// <summary>
		/// Set binary header for the file.
		/// Binary header is only used when writing binary type files.
		/// If both Header and BinaryHeader are specified then BinaryHeader is used.
		/// Maximum length of binary header is 80 bytes, any content over this limit is ignored.
		/// </summary>
		// Token: 0x06006551 RID: 25937 RVA: 0x00091C68 File Offset: 0x0008FE68
		public virtual void SetBinaryHeader(vtkUnsignedCharArray binaryHeader)
		{
			vtkSTLWriter.vtkSTLWriter_SetBinaryHeader_16(base.GetCppThis(), (binaryHeader == null) ? default(HandleRef) : binaryHeader.GetCppThis());
		}

		// Token: 0x06006552 RID: 25938
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSTLWriter_SetFileName_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of vtk polygon data file to write.
		/// </summary>
		// Token: 0x06006553 RID: 25939 RVA: 0x00091C97 File Offset: 0x0008FE97
		public virtual void SetFileName(string _arg)
		{
			vtkSTLWriter.vtkSTLWriter_SetFileName_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06006554 RID: 25940
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSTLWriter_SetFileType_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x06006555 RID: 25941 RVA: 0x00091CA7 File Offset: 0x0008FEA7
		public virtual void SetFileType(int _arg)
		{
			vtkSTLWriter.vtkSTLWriter_SetFileType_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06006556 RID: 25942
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSTLWriter_SetFileTypeToASCII_19(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x06006557 RID: 25943 RVA: 0x00091CB7 File Offset: 0x0008FEB7
		public void SetFileTypeToASCII()
		{
			vtkSTLWriter.vtkSTLWriter_SetFileTypeToASCII_19(base.GetCppThis());
		}

		// Token: 0x06006558 RID: 25944
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSTLWriter_SetFileTypeToBinary_20(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x06006559 RID: 25945 RVA: 0x00091CC6 File Offset: 0x0008FEC6
		public void SetFileTypeToBinary()
		{
			vtkSTLWriter.vtkSTLWriter_SetFileTypeToBinary_20(base.GetCppThis());
		}

		// Token: 0x0600655A RID: 25946
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSTLWriter_SetHeader_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the header for the file as text. The header cannot contain 0x00 characters.
		/// \sa SetBinaryHeader()
		/// </summary>
		// Token: 0x0600655B RID: 25947 RVA: 0x00091CD5 File Offset: 0x0008FED5
		public virtual void SetHeader(string _arg)
		{
			vtkSTLWriter.vtkSTLWriter_SetHeader_21(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000909 RID: 2313
		public new const string MRFullTypeName = "Kitware.VTK.vtkSTLWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400090A RID: 2314
		public new static readonly string MRClassNameKey = "class vtkSTLWriter";
	}
}
