using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPPolyDataWriter
	/// </summary>
	/// <remarks>
	///    Write PVTK XML PolyData files.
	///
	/// vtkXMLPPolyDataWriter writes the PVTK XML PolyData file format.
	/// One poly data input can be written into a parallel file format with
	/// any number of pieces spread across files.  The standard extension
	/// for this writer's file format is "pvtp".  This writer uses
	/// vtkXMLPolyDataWriter to write the individual piece files.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPolyDataWriter
	/// </seealso>
	// Token: 0x0200014B RID: 331
	public class vtkXMLPPolyDataWriter : vtkXMLPUnstructuredDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003F91 RID: 16273 RVA: 0x0005D267 File Offset: 0x0005B467
		static vtkXMLPPolyDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPPolyDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPPolyDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003F92 RID: 16274 RVA: 0x0005D28F File Offset: 0x0005B48F
		public vtkXMLPPolyDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003F93 RID: 16275
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPPolyDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F94 RID: 16276 RVA: 0x0005D2A0 File Offset: 0x0005B4A0
		public new static vtkXMLPPolyDataWriter New()
		{
			vtkXMLPPolyDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPPolyDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F95 RID: 16277 RVA: 0x0005D2F4 File Offset: 0x0005B4F4
		public vtkXMLPPolyDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003F96 RID: 16278 RVA: 0x0005D338 File Offset: 0x0005B538
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003F97 RID: 16279
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPPolyDataWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06003F98 RID: 16280 RVA: 0x0005D344 File Offset: 0x0005B544
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003F99 RID: 16281
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPPolyDataWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer's input.
		/// </summary>
		// Token: 0x06003F9A RID: 16282 RVA: 0x0005D380 File Offset: 0x0005B580
		public new vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003F9B RID: 16283
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPPolyDataWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F9C RID: 16284 RVA: 0x0005D3F0 File Offset: 0x0005B5F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06003F9D RID: 16285
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPPolyDataWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F9E RID: 16286 RVA: 0x0005D410 File Offset: 0x0005B610
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06003F9F RID: 16287
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPPolyDataWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FA0 RID: 16288 RVA: 0x0005D42C File Offset: 0x0005B62C
		public override int IsA(string type)
		{
			return vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06003FA1 RID: 16289
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPPolyDataWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FA2 RID: 16290 RVA: 0x0005D44C File Offset: 0x0005B64C
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_IsTypeOf_06(type);
		}

		// Token: 0x06003FA3 RID: 16291
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPPolyDataWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FA4 RID: 16292 RVA: 0x0005D468 File Offset: 0x0005B668
		public new vtkXMLPPolyDataWriter NewInstance()
		{
			vtkXMLPPolyDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPPolyDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003FA5 RID: 16293
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPPolyDataWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003FA6 RID: 16294 RVA: 0x0005D4C4 File Offset: 0x0005B6C4
		public new static vtkXMLPPolyDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPPolyDataWriter vtkXMLPPolyDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPPolyDataWriter = (vtkXMLPPolyDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPPolyDataWriter.Register(null);
				}
			}
			return vtkXMLPPolyDataWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006DA RID: 1754
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPPolyDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006DB RID: 1755
		public new static readonly string MRClassNameKey = "class vtkXMLPPolyDataWriter";
	}
}
