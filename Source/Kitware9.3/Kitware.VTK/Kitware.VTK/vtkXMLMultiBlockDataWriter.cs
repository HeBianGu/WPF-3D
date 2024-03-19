using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLMultiBlockDataWriter
	/// </summary>
	/// <remarks>
	///    writer for vtkMultiBlockDataSet.
	///
	/// vtkXMLMultiBlockDataWriter is a vtkXMLCompositeDataWriter subclass to handle
	/// vtkMultiBlockDataSet.
	/// </remarks>
	// Token: 0x02000148 RID: 328
	public class vtkXMLMultiBlockDataWriter : vtkXMLCompositeDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003F4E RID: 16206 RVA: 0x0005CB27 File Offset: 0x0005AD27
		static vtkXMLMultiBlockDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLMultiBlockDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLMultiBlockDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003F4F RID: 16207 RVA: 0x0005CB4F File Offset: 0x0005AD4F
		public vtkXMLMultiBlockDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003F50 RID: 16208
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLMultiBlockDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F51 RID: 16209 RVA: 0x0005CB60 File Offset: 0x0005AD60
		public new static vtkXMLMultiBlockDataWriter New()
		{
			vtkXMLMultiBlockDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLMultiBlockDataWriter.vtkXMLMultiBlockDataWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMultiBlockDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F52 RID: 16210 RVA: 0x0005CBB4 File Offset: 0x0005ADB4
		public vtkXMLMultiBlockDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLMultiBlockDataWriter.vtkXMLMultiBlockDataWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003F53 RID: 16211 RVA: 0x0005CBF8 File Offset: 0x0005ADF8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003F54 RID: 16212
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLMultiBlockDataWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06003F55 RID: 16213 RVA: 0x0005CC04 File Offset: 0x0005AE04
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLMultiBlockDataWriter.vtkXMLMultiBlockDataWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003F56 RID: 16214
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLMultiBlockDataWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F57 RID: 16215 RVA: 0x0005CC40 File Offset: 0x0005AE40
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLMultiBlockDataWriter.vtkXMLMultiBlockDataWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06003F58 RID: 16216
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLMultiBlockDataWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F59 RID: 16217 RVA: 0x0005CC60 File Offset: 0x0005AE60
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLMultiBlockDataWriter.vtkXMLMultiBlockDataWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06003F5A RID: 16218
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLMultiBlockDataWriter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F5B RID: 16219 RVA: 0x0005CC7C File Offset: 0x0005AE7C
		public override int IsA(string type)
		{
			return vtkXMLMultiBlockDataWriter.vtkXMLMultiBlockDataWriter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06003F5C RID: 16220
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLMultiBlockDataWriter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F5D RID: 16221 RVA: 0x0005CC9C File Offset: 0x0005AE9C
		public new static int IsTypeOf(string type)
		{
			return vtkXMLMultiBlockDataWriter.vtkXMLMultiBlockDataWriter_IsTypeOf_05(type);
		}

		// Token: 0x06003F5E RID: 16222
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLMultiBlockDataWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F5F RID: 16223 RVA: 0x0005CCB8 File Offset: 0x0005AEB8
		public new vtkXMLMultiBlockDataWriter NewInstance()
		{
			vtkXMLMultiBlockDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLMultiBlockDataWriter.vtkXMLMultiBlockDataWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMultiBlockDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003F60 RID: 16224
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLMultiBlockDataWriter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F61 RID: 16225 RVA: 0x0005CD14 File Offset: 0x0005AF14
		public new static vtkXMLMultiBlockDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLMultiBlockDataWriter vtkXMLMultiBlockDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLMultiBlockDataWriter.vtkXMLMultiBlockDataWriter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLMultiBlockDataWriter = (vtkXMLMultiBlockDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLMultiBlockDataWriter.Register(null);
				}
			}
			return vtkXMLMultiBlockDataWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006D4 RID: 1748
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLMultiBlockDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006D5 RID: 1749
		public new static readonly string MRClassNameKey = "class vtkXMLMultiBlockDataWriter";
	}
}
