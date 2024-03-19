using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMNIObjectWriter
	/// </summary>
	/// <remarks>
	///    A writer for MNI surface mesh files.
	///
	/// The MNI .obj file format is used to store geometrical data.  This
	/// file format was developed at the McConnell Brain Imaging Centre at
	/// the Montreal Neurological Institute and is used by their software.
	/// Only polygon and line files are supported by this writer.  For these
	/// formats, all data elements are written including normals, colors,
	/// and surface properties.  ASCII and binary file types are supported.
	/// </remarks>
	/// <seealso>
	///
	/// vtkMINCImageReader vtkMNIObjectReader vtkMNITransformReader
	/// @par Thanks:
	/// Thanks to David Gobbi for writing this class and Atamai Inc. for
	/// contributing it to VTK.
	/// </seealso>
	// Token: 0x0200017C RID: 380
	public class vtkMNIObjectWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004874 RID: 18548 RVA: 0x000697A3 File Offset: 0x000679A3
		static vtkMNIObjectWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMNIObjectWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMNIObjectWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004875 RID: 18549 RVA: 0x000697CB File Offset: 0x000679CB
		public vtkMNIObjectWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004876 RID: 18550
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004877 RID: 18551 RVA: 0x000697DC File Offset: 0x000679DC
		public new static vtkMNIObjectWriter New()
		{
			vtkMNIObjectWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNIObjectWriter.vtkMNIObjectWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNIObjectWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004878 RID: 18552 RVA: 0x00069830 File Offset: 0x00067A30
		public vtkMNIObjectWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMNIObjectWriter.vtkMNIObjectWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004879 RID: 18553 RVA: 0x00069874 File Offset: 0x00067A74
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600487A RID: 18554
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectWriter_GetDescriptiveName_01(HandleRef pThis);

		/// <summary>
		/// Get the name of this file format.
		/// </summary>
		// Token: 0x0600487B RID: 18555 RVA: 0x00069880 File Offset: 0x00067A80
		public virtual string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNIObjectWriter.vtkMNIObjectWriter_GetDescriptiveName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600487C RID: 18556
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectWriter_GetFileExtensions_02(HandleRef pThis);

		/// <summary>
		/// Get the extension for this file format.
		/// </summary>
		// Token: 0x0600487D RID: 18557 RVA: 0x000698BC File Offset: 0x00067ABC
		public virtual string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNIObjectWriter.vtkMNIObjectWriter_GetFileExtensions_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600487E RID: 18558
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectWriter_GetFileName_03(HandleRef pThis);

		/// <summary>
		/// Specify file name of vtk polygon data file to write.
		/// </summary>
		// Token: 0x0600487F RID: 18559 RVA: 0x000698F8 File Offset: 0x00067AF8
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNIObjectWriter.vtkMNIObjectWriter_GetFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004880 RID: 18560
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNIObjectWriter_GetFileType_04(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x06004881 RID: 18561 RVA: 0x00069934 File Offset: 0x00067B34
		public virtual int GetFileType()
		{
			return vtkMNIObjectWriter.vtkMNIObjectWriter_GetFileType_04(base.GetCppThis());
		}

		// Token: 0x06004882 RID: 18562
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNIObjectWriter_GetFileTypeMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x06004883 RID: 18563 RVA: 0x00069954 File Offset: 0x00067B54
		public virtual int GetFileTypeMaxValue()
		{
			return vtkMNIObjectWriter.vtkMNIObjectWriter_GetFileTypeMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06004884 RID: 18564
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNIObjectWriter_GetFileTypeMinValue_06(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x06004885 RID: 18565 RVA: 0x00069974 File Offset: 0x00067B74
		public virtual int GetFileTypeMinValue()
		{
			return vtkMNIObjectWriter.vtkMNIObjectWriter_GetFileTypeMinValue_06(base.GetCppThis());
		}

		// Token: 0x06004886 RID: 18566
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectWriter_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06004887 RID: 18567 RVA: 0x00069994 File Offset: 0x00067B94
		public new vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNIObjectWriter.vtkMNIObjectWriter_GetInput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004888 RID: 18568
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectWriter_GetInput_08(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06004889 RID: 18569 RVA: 0x00069A04 File Offset: 0x00067C04
		public new vtkPolyData GetInput(int port)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNIObjectWriter.vtkMNIObjectWriter_GetInput_08(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600488A RID: 18570
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectWriter_GetLookupTable_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the lookup table associated with the object.  This will be
		/// used to convert scalar values to colors, if a mapper is not set.
		/// </summary>
		// Token: 0x0600488B RID: 18571 RVA: 0x00069A74 File Offset: 0x00067C74
		public virtual vtkLookupTable GetLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNIObjectWriter.vtkMNIObjectWriter_GetLookupTable_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		// Token: 0x0600488C RID: 18572
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectWriter_GetMapper_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the mapper associated with the object.  Optional.
		/// This is useful for exporting an actor with the same colors
		/// that are used to display the actor within VTK.
		/// </summary>
		// Token: 0x0600488D RID: 18573 RVA: 0x00069AE4 File Offset: 0x00067CE4
		public virtual vtkMapper GetMapper()
		{
			vtkMapper vtkMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNIObjectWriter.vtkMNIObjectWriter_GetMapper_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapper = (vtkMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapper.Register(null);
				}
			}
			return vtkMapper;
		}

		// Token: 0x0600488E RID: 18574
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMNIObjectWriter_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600488F RID: 18575 RVA: 0x00069B54 File Offset: 0x00067D54
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMNIObjectWriter.vtkMNIObjectWriter_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06004890 RID: 18576
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMNIObjectWriter_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004891 RID: 18577 RVA: 0x00069B74 File Offset: 0x00067D74
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMNIObjectWriter.vtkMNIObjectWriter_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06004892 RID: 18578
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectWriter_GetProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the property associated with the object.  Optional.
		/// This is useful for exporting an actor.
		/// </summary>
		// Token: 0x06004893 RID: 18579 RVA: 0x00069B90 File Offset: 0x00067D90
		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNIObjectWriter.vtkMNIObjectWriter_GetProperty_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06004894 RID: 18580
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNIObjectWriter_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004895 RID: 18581 RVA: 0x00069C00 File Offset: 0x00067E00
		public override int IsA(string type)
		{
			return vtkMNIObjectWriter.vtkMNIObjectWriter_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06004896 RID: 18582
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNIObjectWriter_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004897 RID: 18583 RVA: 0x00069C20 File Offset: 0x00067E20
		public new static int IsTypeOf(string type)
		{
			return vtkMNIObjectWriter.vtkMNIObjectWriter_IsTypeOf_15(type);
		}

		// Token: 0x06004898 RID: 18584
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectWriter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004899 RID: 18585 RVA: 0x00069C3C File Offset: 0x00067E3C
		public new vtkMNIObjectWriter NewInstance()
		{
			vtkMNIObjectWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNIObjectWriter.vtkMNIObjectWriter_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNIObjectWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600489A RID: 18586
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectWriter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600489B RID: 18587 RVA: 0x00069C98 File Offset: 0x00067E98
		public new static vtkMNIObjectWriter SafeDownCast(vtkObjectBase o)
		{
			vtkMNIObjectWriter vtkMNIObjectWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNIObjectWriter.vtkMNIObjectWriter_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMNIObjectWriter = (vtkMNIObjectWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMNIObjectWriter.Register(null);
				}
			}
			return vtkMNIObjectWriter;
		}

		// Token: 0x0600489C RID: 18588
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNIObjectWriter_SetFileName_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of vtk polygon data file to write.
		/// </summary>
		// Token: 0x0600489D RID: 18589 RVA: 0x00069D17 File Offset: 0x00067F17
		public virtual void SetFileName(string _arg)
		{
			vtkMNIObjectWriter.vtkMNIObjectWriter_SetFileName_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600489E RID: 18590
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNIObjectWriter_SetFileType_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x0600489F RID: 18591 RVA: 0x00069D27 File Offset: 0x00067F27
		public virtual void SetFileType(int _arg)
		{
			vtkMNIObjectWriter.vtkMNIObjectWriter_SetFileType_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060048A0 RID: 18592
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNIObjectWriter_SetFileTypeToASCII_21(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x060048A1 RID: 18593 RVA: 0x00069D37 File Offset: 0x00067F37
		public void SetFileTypeToASCII()
		{
			vtkMNIObjectWriter.vtkMNIObjectWriter_SetFileTypeToASCII_21(base.GetCppThis());
		}

		// Token: 0x060048A2 RID: 18594
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNIObjectWriter_SetFileTypeToBinary_22(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x060048A3 RID: 18595 RVA: 0x00069D46 File Offset: 0x00067F46
		public void SetFileTypeToBinary()
		{
			vtkMNIObjectWriter.vtkMNIObjectWriter_SetFileTypeToBinary_22(base.GetCppThis());
		}

		// Token: 0x060048A4 RID: 18596
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNIObjectWriter_SetLookupTable_23(HandleRef pThis, HandleRef table);

		/// <summary>
		/// Set the lookup table associated with the object.  This will be
		/// used to convert scalar values to colors, if a mapper is not set.
		/// </summary>
		// Token: 0x060048A5 RID: 18597 RVA: 0x00069D58 File Offset: 0x00067F58
		public virtual void SetLookupTable(vtkLookupTable table)
		{
			vtkMNIObjectWriter.vtkMNIObjectWriter_SetLookupTable_23(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis());
		}

		// Token: 0x060048A6 RID: 18598
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNIObjectWriter_SetMapper_24(HandleRef pThis, HandleRef mapper);

		/// <summary>
		/// Set the mapper associated with the object.  Optional.
		/// This is useful for exporting an actor with the same colors
		/// that are used to display the actor within VTK.
		/// </summary>
		// Token: 0x060048A7 RID: 18599 RVA: 0x00069D88 File Offset: 0x00067F88
		public virtual void SetMapper(vtkMapper mapper)
		{
			vtkMNIObjectWriter.vtkMNIObjectWriter_SetMapper_24(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x060048A8 RID: 18600
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNIObjectWriter_SetProperty_25(HandleRef pThis, HandleRef property);

		/// <summary>
		/// Set the property associated with the object.  Optional.
		/// This is useful for exporting an actor.
		/// </summary>
		// Token: 0x060048A9 RID: 18601 RVA: 0x00069DB8 File Offset: 0x00067FB8
		public virtual void SetProperty(vtkProperty property)
		{
			vtkMNIObjectWriter.vtkMNIObjectWriter_SetProperty_25(base.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000749 RID: 1865
		public new const string MRFullTypeName = "Kitware.VTK.vtkMNIObjectWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400074A RID: 1866
		public new static readonly string MRClassNameKey = "class vtkMNIObjectWriter";
	}
}
