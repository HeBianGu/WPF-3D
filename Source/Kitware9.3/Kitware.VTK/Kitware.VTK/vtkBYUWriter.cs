using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBYUWriter
	/// </summary>
	/// <remarks>
	///    write MOVIE.BYU files
	///
	/// vtkBYUWriter writes MOVIE.BYU polygonal files. These files consist
	/// of a geometry file (.g), a scalar file (.s), a displacement or
	/// vector file (.d), and a 2D texture coordinate file (.t). These files
	/// must be specified to the object, the appropriate boolean
	/// variables must be true, and data must be available from the input
	/// for the files to be written.
	/// WARNING: this writer does not currently write triangle strips. Use
	/// vtkTriangleFilter to convert strips to triangles.
	/// </remarks>
	// Token: 0x020001FC RID: 508
	public class vtkBYUWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060061DC RID: 25052 RVA: 0x0008CE17 File Offset: 0x0008B017
		static vtkBYUWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBYUWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBYUWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060061DD RID: 25053 RVA: 0x0008CE3F File Offset: 0x0008B03F
		public vtkBYUWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060061DE RID: 25054
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060061DF RID: 25055 RVA: 0x0008CE50 File Offset: 0x0008B050
		public new static vtkBYUWriter New()
		{
			vtkBYUWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBYUWriter.vtkBYUWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBYUWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060061E0 RID: 25056 RVA: 0x0008CEA4 File Offset: 0x0008B0A4
		public vtkBYUWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBYUWriter.vtkBYUWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060061E1 RID: 25057 RVA: 0x0008CEE8 File Offset: 0x0008B0E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060061E2 RID: 25058
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUWriter_GetDisplacementFileName_01(HandleRef pThis);

		/// <summary>
		/// Specify the name of the displacement file to write.
		/// </summary>
		// Token: 0x060061E3 RID: 25059 RVA: 0x0008CEF4 File Offset: 0x0008B0F4
		public virtual string GetDisplacementFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkBYUWriter.vtkBYUWriter_GetDisplacementFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060061E4 RID: 25060
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUWriter_GetGeometryFileName_02(HandleRef pThis);

		/// <summary>
		/// Specify the name of the geometry file to write.
		/// </summary>
		// Token: 0x060061E5 RID: 25061 RVA: 0x0008CF30 File Offset: 0x0008B130
		public virtual string GetGeometryFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkBYUWriter.vtkBYUWriter_GetGeometryFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060061E6 RID: 25062
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUWriter_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x060061E7 RID: 25063 RVA: 0x0008CF6C File Offset: 0x0008B16C
		public new vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBYUWriter.vtkBYUWriter_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060061E8 RID: 25064
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUWriter_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x060061E9 RID: 25065 RVA: 0x0008CFDC File Offset: 0x0008B1DC
		public new vtkPolyData GetInput(int port)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBYUWriter.vtkBYUWriter_GetInput_04(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060061EA RID: 25066
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBYUWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060061EB RID: 25067 RVA: 0x0008D04C File Offset: 0x0008B24C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBYUWriter.vtkBYUWriter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060061EC RID: 25068
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBYUWriter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060061ED RID: 25069 RVA: 0x0008D06C File Offset: 0x0008B26C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBYUWriter.vtkBYUWriter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060061EE RID: 25070
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUWriter_GetScalarFileName_07(HandleRef pThis);

		/// <summary>
		/// Specify the name of the scalar file to write.
		/// </summary>
		// Token: 0x060061EF RID: 25071 RVA: 0x0008D088 File Offset: 0x0008B288
		public virtual string GetScalarFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkBYUWriter.vtkBYUWriter_GetScalarFileName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060061F0 RID: 25072
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUWriter_GetTextureFileName_08(HandleRef pThis);

		/// <summary>
		/// Specify the name of the texture file to write.
		/// </summary>
		// Token: 0x060061F1 RID: 25073 RVA: 0x0008D0C4 File Offset: 0x0008B2C4
		public virtual string GetTextureFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkBYUWriter.vtkBYUWriter_GetTextureFileName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060061F2 RID: 25074
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBYUWriter_GetWriteDisplacement_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing the displacement file.
		/// </summary>
		// Token: 0x060061F3 RID: 25075 RVA: 0x0008D100 File Offset: 0x0008B300
		public virtual int GetWriteDisplacement()
		{
			return vtkBYUWriter.vtkBYUWriter_GetWriteDisplacement_09(base.GetCppThis());
		}

		// Token: 0x060061F4 RID: 25076
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBYUWriter_GetWriteScalar_10(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing the scalar file.
		/// </summary>
		// Token: 0x060061F5 RID: 25077 RVA: 0x0008D120 File Offset: 0x0008B320
		public virtual int GetWriteScalar()
		{
			return vtkBYUWriter.vtkBYUWriter_GetWriteScalar_10(base.GetCppThis());
		}

		// Token: 0x060061F6 RID: 25078
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBYUWriter_GetWriteTexture_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing the texture file.
		/// </summary>
		// Token: 0x060061F7 RID: 25079 RVA: 0x0008D140 File Offset: 0x0008B340
		public virtual int GetWriteTexture()
		{
			return vtkBYUWriter.vtkBYUWriter_GetWriteTexture_11(base.GetCppThis());
		}

		// Token: 0x060061F8 RID: 25080
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBYUWriter_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060061F9 RID: 25081 RVA: 0x0008D160 File Offset: 0x0008B360
		public override int IsA(string type)
		{
			return vtkBYUWriter.vtkBYUWriter_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x060061FA RID: 25082
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBYUWriter_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060061FB RID: 25083 RVA: 0x0008D180 File Offset: 0x0008B380
		public new static int IsTypeOf(string type)
		{
			return vtkBYUWriter.vtkBYUWriter_IsTypeOf_13(type);
		}

		// Token: 0x060061FC RID: 25084
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUWriter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060061FD RID: 25085 RVA: 0x0008D19C File Offset: 0x0008B39C
		public new vtkBYUWriter NewInstance()
		{
			vtkBYUWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBYUWriter.vtkBYUWriter_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBYUWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060061FE RID: 25086
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBYUWriter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060061FF RID: 25087 RVA: 0x0008D1F8 File Offset: 0x0008B3F8
		public new static vtkBYUWriter SafeDownCast(vtkObjectBase o)
		{
			vtkBYUWriter vtkBYUWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBYUWriter.vtkBYUWriter_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBYUWriter = (vtkBYUWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBYUWriter.Register(null);
				}
			}
			return vtkBYUWriter;
		}

		// Token: 0x06006200 RID: 25088
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUWriter_SetDisplacementFileName_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the displacement file to write.
		/// </summary>
		// Token: 0x06006201 RID: 25089 RVA: 0x0008D277 File Offset: 0x0008B477
		public virtual void SetDisplacementFileName(string _arg)
		{
			vtkBYUWriter.vtkBYUWriter_SetDisplacementFileName_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06006202 RID: 25090
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUWriter_SetGeometryFileName_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the geometry file to write.
		/// </summary>
		// Token: 0x06006203 RID: 25091 RVA: 0x0008D287 File Offset: 0x0008B487
		public virtual void SetGeometryFileName(string _arg)
		{
			vtkBYUWriter.vtkBYUWriter_SetGeometryFileName_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06006204 RID: 25092
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUWriter_SetScalarFileName_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the scalar file to write.
		/// </summary>
		// Token: 0x06006205 RID: 25093 RVA: 0x0008D297 File Offset: 0x0008B497
		public virtual void SetScalarFileName(string _arg)
		{
			vtkBYUWriter.vtkBYUWriter_SetScalarFileName_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06006206 RID: 25094
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUWriter_SetTextureFileName_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the texture file to write.
		/// </summary>
		// Token: 0x06006207 RID: 25095 RVA: 0x0008D2A7 File Offset: 0x0008B4A7
		public virtual void SetTextureFileName(string _arg)
		{
			vtkBYUWriter.vtkBYUWriter_SetTextureFileName_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06006208 RID: 25096
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUWriter_SetWriteDisplacement_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off writing the displacement file.
		/// </summary>
		// Token: 0x06006209 RID: 25097 RVA: 0x0008D2B7 File Offset: 0x0008B4B7
		public virtual void SetWriteDisplacement(int _arg)
		{
			vtkBYUWriter.vtkBYUWriter_SetWriteDisplacement_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600620A RID: 25098
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUWriter_SetWriteScalar_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off writing the scalar file.
		/// </summary>
		// Token: 0x0600620B RID: 25099 RVA: 0x0008D2C7 File Offset: 0x0008B4C7
		public virtual void SetWriteScalar(int _arg)
		{
			vtkBYUWriter.vtkBYUWriter_SetWriteScalar_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600620C RID: 25100
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUWriter_SetWriteTexture_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off writing the texture file.
		/// </summary>
		// Token: 0x0600620D RID: 25101 RVA: 0x0008D2D7 File Offset: 0x0008B4D7
		public virtual void SetWriteTexture(int _arg)
		{
			vtkBYUWriter.vtkBYUWriter_SetWriteTexture_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600620E RID: 25102
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUWriter_WriteDisplacementOff_24(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing the displacement file.
		/// </summary>
		// Token: 0x0600620F RID: 25103 RVA: 0x0008D2E7 File Offset: 0x0008B4E7
		public virtual void WriteDisplacementOff()
		{
			vtkBYUWriter.vtkBYUWriter_WriteDisplacementOff_24(base.GetCppThis());
		}

		// Token: 0x06006210 RID: 25104
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUWriter_WriteDisplacementOn_25(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing the displacement file.
		/// </summary>
		// Token: 0x06006211 RID: 25105 RVA: 0x0008D2F6 File Offset: 0x0008B4F6
		public virtual void WriteDisplacementOn()
		{
			vtkBYUWriter.vtkBYUWriter_WriteDisplacementOn_25(base.GetCppThis());
		}

		// Token: 0x06006212 RID: 25106
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUWriter_WriteScalarOff_26(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing the scalar file.
		/// </summary>
		// Token: 0x06006213 RID: 25107 RVA: 0x0008D305 File Offset: 0x0008B505
		public virtual void WriteScalarOff()
		{
			vtkBYUWriter.vtkBYUWriter_WriteScalarOff_26(base.GetCppThis());
		}

		// Token: 0x06006214 RID: 25108
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUWriter_WriteScalarOn_27(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing the scalar file.
		/// </summary>
		// Token: 0x06006215 RID: 25109 RVA: 0x0008D314 File Offset: 0x0008B514
		public virtual void WriteScalarOn()
		{
			vtkBYUWriter.vtkBYUWriter_WriteScalarOn_27(base.GetCppThis());
		}

		// Token: 0x06006216 RID: 25110
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUWriter_WriteTextureOff_28(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing the texture file.
		/// </summary>
		// Token: 0x06006217 RID: 25111 RVA: 0x0008D323 File Offset: 0x0008B523
		public virtual void WriteTextureOff()
		{
			vtkBYUWriter.vtkBYUWriter_WriteTextureOff_28(base.GetCppThis());
		}

		// Token: 0x06006218 RID: 25112
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBYUWriter_WriteTextureOn_29(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing the texture file.
		/// </summary>
		// Token: 0x06006219 RID: 25113 RVA: 0x0008D332 File Offset: 0x0008B532
		public virtual void WriteTextureOn()
		{
			vtkBYUWriter.vtkBYUWriter_WriteTextureOn_29(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008C2 RID: 2242
		public new const string MRFullTypeName = "Kitware.VTK.vtkBYUWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008C3 RID: 2243
		public new static readonly string MRClassNameKey = "class vtkBYUWriter";
	}
}
