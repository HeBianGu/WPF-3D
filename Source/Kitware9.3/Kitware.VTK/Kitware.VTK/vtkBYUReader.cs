using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBYUReader
	/// </summary>
	/// <remarks>
	///    read MOVIE.BYU polygon files
	///
	/// vtkBYUReader is a source object that reads MOVIE.BYU polygon files.
	/// These files consist of a geometry file (.g), a scalar file (.s), a
	/// displacement or vector file (.d), and a 2D texture coordinate file
	/// (.t).
	/// </remarks>
	// Token: 0x020001FB RID: 507
	public class vtkBYUReader : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006194 RID: 24980 RVA: 0x0008C8F7 File Offset: 0x0008AAF7
		static vtkBYUReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBYUReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBYUReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006195 RID: 24981 RVA: 0x0008C91F File Offset: 0x0008AB1F
		public vtkBYUReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006196 RID: 24982
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006197 RID: 24983 RVA: 0x0008C930 File Offset: 0x0008AB30
		public new static vtkBYUReader New()
		{
			vtkBYUReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBYUReader.vtkBYUReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBYUReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006198 RID: 24984 RVA: 0x0008C984 File Offset: 0x0008AB84
		public vtkBYUReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBYUReader.vtkBYUReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006199 RID: 24985 RVA: 0x0008C9C8 File Offset: 0x0008ABC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600619A RID: 24986
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBYUReader_CanReadFile_01([MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Returns 1 if this file can be read and 0 if the file cannot be read.
		/// Because BYU files do not have anything in the header specifying the file
		/// type, the result is not definitive.  Invalid files may still return 1
		/// although a valid file will never return 0.
		/// </summary>
		// Token: 0x0600619B RID: 24987 RVA: 0x0008C9D4 File Offset: 0x0008ABD4
		public static int CanReadFile(string filename)
		{
			return vtkBYUReader.vtkBYUReader_CanReadFile_01(filename);
		}

		// Token: 0x0600619C RID: 24988
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUReader_GetDisplacementFileName_02(HandleRef pThis);

		/// <summary>
		/// Specify name of displacement FileName.
		/// </summary>
		// Token: 0x0600619D RID: 24989 RVA: 0x0008C9F0 File Offset: 0x0008ABF0
		public virtual string GetDisplacementFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkBYUReader.vtkBYUReader_GetDisplacementFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600619E RID: 24990
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUReader_GetFileName_03(HandleRef pThis);

		/// <summary>
		/// Specify name of geometry FileName (alias).
		/// </summary>
		// Token: 0x0600619F RID: 24991 RVA: 0x0008CA2C File Offset: 0x0008AC2C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkBYUReader.vtkBYUReader_GetFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060061A0 RID: 24992
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUReader_GetGeometryFileName_04(HandleRef pThis);

		/// <summary>
		/// Specify name of geometry FileName.
		/// </summary>
		// Token: 0x060061A1 RID: 24993 RVA: 0x0008CA68 File Offset: 0x0008AC68
		public virtual string GetGeometryFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkBYUReader.vtkBYUReader_GetGeometryFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060061A2 RID: 24994
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBYUReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060061A3 RID: 24995 RVA: 0x0008CAA4 File Offset: 0x0008ACA4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBYUReader.vtkBYUReader_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060061A4 RID: 24996
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBYUReader_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060061A5 RID: 24997 RVA: 0x0008CAC4 File Offset: 0x0008ACC4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBYUReader.vtkBYUReader_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060061A6 RID: 24998
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBYUReader_GetPartNumber_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the part number to be read.
		/// </summary>
		// Token: 0x060061A7 RID: 24999 RVA: 0x0008CAE0 File Offset: 0x0008ACE0
		public virtual int GetPartNumber()
		{
			return vtkBYUReader.vtkBYUReader_GetPartNumber_07(base.GetCppThis());
		}

		// Token: 0x060061A8 RID: 25000
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBYUReader_GetPartNumberMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the part number to be read.
		/// </summary>
		// Token: 0x060061A9 RID: 25001 RVA: 0x0008CB00 File Offset: 0x0008AD00
		public virtual int GetPartNumberMaxValue()
		{
			return vtkBYUReader.vtkBYUReader_GetPartNumberMaxValue_08(base.GetCppThis());
		}

		// Token: 0x060061AA RID: 25002
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBYUReader_GetPartNumberMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the part number to be read.
		/// </summary>
		// Token: 0x060061AB RID: 25003 RVA: 0x0008CB20 File Offset: 0x0008AD20
		public virtual int GetPartNumberMinValue()
		{
			return vtkBYUReader.vtkBYUReader_GetPartNumberMinValue_09(base.GetCppThis());
		}

		// Token: 0x060061AC RID: 25004
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBYUReader_GetReadDisplacement_10(HandleRef pThis);

		/// <summary>
		/// Turn on/off the reading of the displacement file.
		/// </summary>
		// Token: 0x060061AD RID: 25005 RVA: 0x0008CB40 File Offset: 0x0008AD40
		public virtual int GetReadDisplacement()
		{
			return vtkBYUReader.vtkBYUReader_GetReadDisplacement_10(base.GetCppThis());
		}

		// Token: 0x060061AE RID: 25006
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBYUReader_GetReadScalar_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off the reading of the scalar file.
		/// </summary>
		// Token: 0x060061AF RID: 25007 RVA: 0x0008CB60 File Offset: 0x0008AD60
		public virtual int GetReadScalar()
		{
			return vtkBYUReader.vtkBYUReader_GetReadScalar_11(base.GetCppThis());
		}

		// Token: 0x060061B0 RID: 25008
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBYUReader_GetReadTexture_12(HandleRef pThis);

		/// <summary>
		/// Turn on/off the reading of the texture coordinate file.
		/// Specify name of geometry FileName.
		/// </summary>
		// Token: 0x060061B1 RID: 25009 RVA: 0x0008CB80 File Offset: 0x0008AD80
		public virtual int GetReadTexture()
		{
			return vtkBYUReader.vtkBYUReader_GetReadTexture_12(base.GetCppThis());
		}

		// Token: 0x060061B2 RID: 25010
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUReader_GetScalarFileName_13(HandleRef pThis);

		/// <summary>
		/// Specify name of scalar FileName.
		/// </summary>
		// Token: 0x060061B3 RID: 25011 RVA: 0x0008CBA0 File Offset: 0x0008ADA0
		public virtual string GetScalarFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkBYUReader.vtkBYUReader_GetScalarFileName_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060061B4 RID: 25012
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUReader_GetTextureFileName_14(HandleRef pThis);

		/// <summary>
		/// Specify name of texture coordinates FileName.
		/// </summary>
		// Token: 0x060061B5 RID: 25013 RVA: 0x0008CBDC File Offset: 0x0008ADDC
		public virtual string GetTextureFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkBYUReader.vtkBYUReader_GetTextureFileName_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060061B6 RID: 25014
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBYUReader_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060061B7 RID: 25015 RVA: 0x0008CC18 File Offset: 0x0008AE18
		public override int IsA(string type)
		{
			return vtkBYUReader.vtkBYUReader_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x060061B8 RID: 25016
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBYUReader_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060061B9 RID: 25017 RVA: 0x0008CC38 File Offset: 0x0008AE38
		public new static int IsTypeOf(string type)
		{
			return vtkBYUReader.vtkBYUReader_IsTypeOf_16(type);
		}

		// Token: 0x060061BA RID: 25018
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUReader_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060061BB RID: 25019 RVA: 0x0008CC54 File Offset: 0x0008AE54
		public new vtkBYUReader NewInstance()
		{
			vtkBYUReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBYUReader.vtkBYUReader_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBYUReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060061BC RID: 25020
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_ReadDisplacementOff_19(HandleRef pThis);

		/// <summary>
		/// Turn on/off the reading of the displacement file.
		/// </summary>
		// Token: 0x060061BD RID: 25021 RVA: 0x0008CCAE File Offset: 0x0008AEAE
		public virtual void ReadDisplacementOff()
		{
			vtkBYUReader.vtkBYUReader_ReadDisplacementOff_19(base.GetCppThis());
		}

		// Token: 0x060061BE RID: 25022
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_ReadDisplacementOn_20(HandleRef pThis);

		/// <summary>
		/// Turn on/off the reading of the displacement file.
		/// </summary>
		// Token: 0x060061BF RID: 25023 RVA: 0x0008CCBD File Offset: 0x0008AEBD
		public virtual void ReadDisplacementOn()
		{
			vtkBYUReader.vtkBYUReader_ReadDisplacementOn_20(base.GetCppThis());
		}

		// Token: 0x060061C0 RID: 25024
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_ReadScalarOff_21(HandleRef pThis);

		/// <summary>
		/// Turn on/off the reading of the scalar file.
		/// </summary>
		// Token: 0x060061C1 RID: 25025 RVA: 0x0008CCCC File Offset: 0x0008AECC
		public virtual void ReadScalarOff()
		{
			vtkBYUReader.vtkBYUReader_ReadScalarOff_21(base.GetCppThis());
		}

		// Token: 0x060061C2 RID: 25026
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_ReadScalarOn_22(HandleRef pThis);

		/// <summary>
		/// Turn on/off the reading of the scalar file.
		/// </summary>
		// Token: 0x060061C3 RID: 25027 RVA: 0x0008CCDB File Offset: 0x0008AEDB
		public virtual void ReadScalarOn()
		{
			vtkBYUReader.vtkBYUReader_ReadScalarOn_22(base.GetCppThis());
		}

		// Token: 0x060061C4 RID: 25028
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_ReadTextureOff_23(HandleRef pThis);

		/// <summary>
		/// Turn on/off the reading of the texture coordinate file.
		/// Specify name of geometry FileName.
		/// </summary>
		// Token: 0x060061C5 RID: 25029 RVA: 0x0008CCEA File Offset: 0x0008AEEA
		public virtual void ReadTextureOff()
		{
			vtkBYUReader.vtkBYUReader_ReadTextureOff_23(base.GetCppThis());
		}

		// Token: 0x060061C6 RID: 25030
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_ReadTextureOn_24(HandleRef pThis);

		/// <summary>
		/// Turn on/off the reading of the texture coordinate file.
		/// Specify name of geometry FileName.
		/// </summary>
		// Token: 0x060061C7 RID: 25031 RVA: 0x0008CCF9 File Offset: 0x0008AEF9
		public virtual void ReadTextureOn()
		{
			vtkBYUReader.vtkBYUReader_ReadTextureOn_24(base.GetCppThis());
		}

		// Token: 0x060061C8 RID: 25032
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUReader_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060061C9 RID: 25033 RVA: 0x0008CD08 File Offset: 0x0008AF08
		public new static vtkBYUReader SafeDownCast(vtkObjectBase o)
		{
			vtkBYUReader vtkBYUReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBYUReader.vtkBYUReader_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBYUReader = (vtkBYUReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBYUReader.Register(null);
				}
			}
			return vtkBYUReader;
		}

		// Token: 0x060061CA RID: 25034
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_SetDisplacementFileName_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify name of displacement FileName.
		/// </summary>
		// Token: 0x060061CB RID: 25035 RVA: 0x0008CD87 File Offset: 0x0008AF87
		public virtual void SetDisplacementFileName(string _arg)
		{
			vtkBYUReader.vtkBYUReader_SetDisplacementFileName_26(base.GetCppThis(), _arg);
		}

		// Token: 0x060061CC RID: 25036
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_SetFileName_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string f);

		/// <summary>
		/// Specify name of geometry FileName (alias).
		/// </summary>
		// Token: 0x060061CD RID: 25037 RVA: 0x0008CD97 File Offset: 0x0008AF97
		public virtual void SetFileName(string f)
		{
			vtkBYUReader.vtkBYUReader_SetFileName_27(base.GetCppThis(), f);
		}

		// Token: 0x060061CE RID: 25038
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_SetGeometryFileName_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify name of geometry FileName.
		/// </summary>
		// Token: 0x060061CF RID: 25039 RVA: 0x0008CDA7 File Offset: 0x0008AFA7
		public virtual void SetGeometryFileName(string _arg)
		{
			vtkBYUReader.vtkBYUReader_SetGeometryFileName_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060061D0 RID: 25040
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_SetPartNumber_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the part number to be read.
		/// </summary>
		// Token: 0x060061D1 RID: 25041 RVA: 0x0008CDB7 File Offset: 0x0008AFB7
		public virtual void SetPartNumber(int _arg)
		{
			vtkBYUReader.vtkBYUReader_SetPartNumber_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060061D2 RID: 25042
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_SetReadDisplacement_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the reading of the displacement file.
		/// </summary>
		// Token: 0x060061D3 RID: 25043 RVA: 0x0008CDC7 File Offset: 0x0008AFC7
		public virtual void SetReadDisplacement(int _arg)
		{
			vtkBYUReader.vtkBYUReader_SetReadDisplacement_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060061D4 RID: 25044
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_SetReadScalar_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the reading of the scalar file.
		/// </summary>
		// Token: 0x060061D5 RID: 25045 RVA: 0x0008CDD7 File Offset: 0x0008AFD7
		public virtual void SetReadScalar(int _arg)
		{
			vtkBYUReader.vtkBYUReader_SetReadScalar_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060061D6 RID: 25046
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_SetReadTexture_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the reading of the texture coordinate file.
		/// Specify name of geometry FileName.
		/// </summary>
		// Token: 0x060061D7 RID: 25047 RVA: 0x0008CDE7 File Offset: 0x0008AFE7
		public virtual void SetReadTexture(int _arg)
		{
			vtkBYUReader.vtkBYUReader_SetReadTexture_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060061D8 RID: 25048
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_SetScalarFileName_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify name of scalar FileName.
		/// </summary>
		// Token: 0x060061D9 RID: 25049 RVA: 0x0008CDF7 File Offset: 0x0008AFF7
		public virtual void SetScalarFileName(string _arg)
		{
			vtkBYUReader.vtkBYUReader_SetScalarFileName_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060061DA RID: 25050
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUReader_SetTextureFileName_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify name of texture coordinates FileName.
		/// </summary>
		// Token: 0x060061DB RID: 25051 RVA: 0x0008CE07 File Offset: 0x0008B007
		public virtual void SetTextureFileName(string _arg)
		{
			vtkBYUReader.vtkBYUReader_SetTextureFileName_34(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008C0 RID: 2240
		public new const string MRFullTypeName = "Kitware.VTK.vtkBYUReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008C1 RID: 2241
		public new static readonly string MRClassNameKey = "class vtkBYUReader";
	}
}
