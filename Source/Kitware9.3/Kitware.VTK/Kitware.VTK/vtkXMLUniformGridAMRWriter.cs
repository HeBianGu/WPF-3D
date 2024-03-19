using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLUniformGridAMRWriter
	/// </summary>
	/// <remarks>
	///    writer for vtkUniformGridAMR.
	///
	/// vtkXMLUniformGridAMRWriter is a vtkXMLCompositeDataWriter subclass to
	/// handle vtkUniformGridAMR datasets (including vtkNonOverlappingAMR and
	/// vtkOverlappingAMR).
	/// </remarks>
	// Token: 0x02000143 RID: 323
	public class vtkXMLUniformGridAMRWriter : vtkXMLCompositeDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003EEB RID: 16107 RVA: 0x0005BF3B File Offset: 0x0005A13B
		static vtkXMLUniformGridAMRWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLUniformGridAMRWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLUniformGridAMRWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003EEC RID: 16108 RVA: 0x0005BF63 File Offset: 0x0005A163
		public vtkXMLUniformGridAMRWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003EED RID: 16109
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUniformGridAMRWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EEE RID: 16110 RVA: 0x0005BF74 File Offset: 0x0005A174
		public new static vtkXMLUniformGridAMRWriter New()
		{
			vtkXMLUniformGridAMRWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUniformGridAMRWriter.vtkXMLUniformGridAMRWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUniformGridAMRWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EEF RID: 16111 RVA: 0x0005BFC8 File Offset: 0x0005A1C8
		public vtkXMLUniformGridAMRWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLUniformGridAMRWriter.vtkXMLUniformGridAMRWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003EF0 RID: 16112 RVA: 0x0005C00C File Offset: 0x0005A20C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003EF1 RID: 16113
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUniformGridAMRWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06003EF2 RID: 16114 RVA: 0x0005C018 File Offset: 0x0005A218
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLUniformGridAMRWriter.vtkXMLUniformGridAMRWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003EF3 RID: 16115
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUniformGridAMRWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EF4 RID: 16116 RVA: 0x0005C054 File Offset: 0x0005A254
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLUniformGridAMRWriter.vtkXMLUniformGridAMRWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06003EF5 RID: 16117
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUniformGridAMRWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EF6 RID: 16118 RVA: 0x0005C074 File Offset: 0x0005A274
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLUniformGridAMRWriter.vtkXMLUniformGridAMRWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06003EF7 RID: 16119
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUniformGridAMRWriter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EF8 RID: 16120 RVA: 0x0005C090 File Offset: 0x0005A290
		public override int IsA(string type)
		{
			return vtkXMLUniformGridAMRWriter.vtkXMLUniformGridAMRWriter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06003EF9 RID: 16121
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUniformGridAMRWriter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EFA RID: 16122 RVA: 0x0005C0B0 File Offset: 0x0005A2B0
		public new static int IsTypeOf(string type)
		{
			return vtkXMLUniformGridAMRWriter.vtkXMLUniformGridAMRWriter_IsTypeOf_05(type);
		}

		// Token: 0x06003EFB RID: 16123
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUniformGridAMRWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EFC RID: 16124 RVA: 0x0005C0CC File Offset: 0x0005A2CC
		public new vtkXMLUniformGridAMRWriter NewInstance()
		{
			vtkXMLUniformGridAMRWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUniformGridAMRWriter.vtkXMLUniformGridAMRWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUniformGridAMRWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003EFD RID: 16125
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUniformGridAMRWriter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EFE RID: 16126 RVA: 0x0005C128 File Offset: 0x0005A328
		public new static vtkXMLUniformGridAMRWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLUniformGridAMRWriter vtkXMLUniformGridAMRWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUniformGridAMRWriter.vtkXMLUniformGridAMRWriter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLUniformGridAMRWriter = (vtkXMLUniformGridAMRWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLUniformGridAMRWriter.Register(null);
				}
			}
			return vtkXMLUniformGridAMRWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006CA RID: 1738
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLUniformGridAMRWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006CB RID: 1739
		public new static readonly string MRClassNameKey = "class vtkXMLUniformGridAMRWriter";
	}
}
