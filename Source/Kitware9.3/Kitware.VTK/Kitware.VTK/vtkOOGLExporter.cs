using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOOGLExporter
	/// </summary>
	/// <remarks>
	///    export a scene into Geomview OOGL format.
	///
	/// vtkOOGLExporter is a concrete subclass of vtkExporter that writes
	/// Geomview OOGL files.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExporter
	/// </seealso>
	// Token: 0x020001ED RID: 493
	public class vtkOOGLExporter : vtkExporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005DBC RID: 23996 RVA: 0x00087EF3 File Offset: 0x000860F3
		static vtkOOGLExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOOGLExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOOGLExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005DBD RID: 23997 RVA: 0x00087F1B File Offset: 0x0008611B
		public vtkOOGLExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005DBE RID: 23998
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOOGLExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DBF RID: 23999 RVA: 0x00087F2C File Offset: 0x0008612C
		public new static vtkOOGLExporter New()
		{
			vtkOOGLExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOOGLExporter.vtkOOGLExporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOOGLExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DC0 RID: 24000 RVA: 0x00087F80 File Offset: 0x00086180
		public vtkOOGLExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOOGLExporter.vtkOOGLExporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005DC1 RID: 24001 RVA: 0x00087FC4 File Offset: 0x000861C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005DC2 RID: 24002
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOOGLExporter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Specify the name of the Geomview file to write.
		/// </summary>
		// Token: 0x06005DC3 RID: 24003 RVA: 0x00087FD0 File Offset: 0x000861D0
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkOOGLExporter.vtkOOGLExporter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005DC4 RID: 24004
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOOGLExporter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DC5 RID: 24005 RVA: 0x0008800C File Offset: 0x0008620C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOOGLExporter.vtkOOGLExporter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06005DC6 RID: 24006
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOOGLExporter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DC7 RID: 24007 RVA: 0x0008802C File Offset: 0x0008622C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOOGLExporter.vtkOOGLExporter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06005DC8 RID: 24008
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOOGLExporter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DC9 RID: 24009 RVA: 0x00088048 File Offset: 0x00086248
		public override int IsA(string type)
		{
			return vtkOOGLExporter.vtkOOGLExporter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06005DCA RID: 24010
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOOGLExporter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DCB RID: 24011 RVA: 0x00088068 File Offset: 0x00086268
		public new static int IsTypeOf(string type)
		{
			return vtkOOGLExporter.vtkOOGLExporter_IsTypeOf_05(type);
		}

		// Token: 0x06005DCC RID: 24012
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOOGLExporter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DCD RID: 24013 RVA: 0x00088084 File Offset: 0x00086284
		public new vtkOOGLExporter NewInstance()
		{
			vtkOOGLExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOOGLExporter.vtkOOGLExporter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOOGLExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005DCE RID: 24014
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOOGLExporter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DCF RID: 24015 RVA: 0x000880E0 File Offset: 0x000862E0
		public new static vtkOOGLExporter SafeDownCast(vtkObjectBase o)
		{
			vtkOOGLExporter vtkOOGLExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOOGLExporter.vtkOOGLExporter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOOGLExporter = (vtkOOGLExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOOGLExporter.Register(null);
				}
			}
			return vtkOOGLExporter;
		}

		// Token: 0x06005DD0 RID: 24016
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOOGLExporter_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the Geomview file to write.
		/// </summary>
		// Token: 0x06005DD1 RID: 24017 RVA: 0x0008815F File Offset: 0x0008635F
		public virtual void SetFileName(string _arg)
		{
			vtkOOGLExporter.vtkOOGLExporter_SetFileName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008A4 RID: 2212
		public new const string MRFullTypeName = "Kitware.VTK.vtkOOGLExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008A5 RID: 2213
		public new static readonly string MRClassNameKey = "class vtkOOGLExporter";
	}
}
