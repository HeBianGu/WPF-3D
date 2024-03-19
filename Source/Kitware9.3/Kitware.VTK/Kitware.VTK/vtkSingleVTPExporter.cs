using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSingleVTPExporter
	/// </summary>
	/// <remarks>
	///    export a scene into a single vtp file and png texture
	///
	/// vtkSingleVTPExporter is a concrete subclass of vtkExporter that writes
	/// a .vtp file and a .png file containing the polydata and texture
	/// elements of the scene.
	///
	/// If ActiveRenderer is specified then it exports contents of
	/// ActiveRenderer. Otherwise it exports contents of all renderers.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExporter
	/// </seealso>
	// Token: 0x020001F4 RID: 500
	public class vtkSingleVTPExporter : vtkExporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006078 RID: 24696 RVA: 0x0008AE81 File Offset: 0x00089081
		static vtkSingleVTPExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSingleVTPExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSingleVTPExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006079 RID: 24697 RVA: 0x0008AEA9 File Offset: 0x000890A9
		public vtkSingleVTPExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600607A RID: 24698
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSingleVTPExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600607B RID: 24699 RVA: 0x0008AEB8 File Offset: 0x000890B8
		public new static vtkSingleVTPExporter New()
		{
			vtkSingleVTPExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSingleVTPExporter.vtkSingleVTPExporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSingleVTPExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600607C RID: 24700 RVA: 0x0008AF0C File Offset: 0x0008910C
		public vtkSingleVTPExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSingleVTPExporter.vtkSingleVTPExporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600607D RID: 24701 RVA: 0x0008AF50 File Offset: 0x00089150
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600607E RID: 24702
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSingleVTPExporter_GetFilePrefix_01(HandleRef pThis);

		/// <summary>
		/// Specify the prefix of the files to write out. The resulting filenames
		/// will have .vtp and .png appended to them.
		/// </summary>
		// Token: 0x0600607F RID: 24703 RVA: 0x0008AF5C File Offset: 0x0008915C
		public virtual string GetFilePrefix()
		{
			string s = Marshal.PtrToStringAnsi(vtkSingleVTPExporter.vtkSingleVTPExporter_GetFilePrefix_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006080 RID: 24704
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSingleVTPExporter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006081 RID: 24705 RVA: 0x0008AF98 File Offset: 0x00089198
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSingleVTPExporter.vtkSingleVTPExporter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06006082 RID: 24706
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSingleVTPExporter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006083 RID: 24707 RVA: 0x0008AFB8 File Offset: 0x000891B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSingleVTPExporter.vtkSingleVTPExporter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06006084 RID: 24708
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSingleVTPExporter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006085 RID: 24709 RVA: 0x0008AFD4 File Offset: 0x000891D4
		public override int IsA(string type)
		{
			return vtkSingleVTPExporter.vtkSingleVTPExporter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06006086 RID: 24710
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSingleVTPExporter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006087 RID: 24711 RVA: 0x0008AFF4 File Offset: 0x000891F4
		public new static int IsTypeOf(string type)
		{
			return vtkSingleVTPExporter.vtkSingleVTPExporter_IsTypeOf_05(type);
		}

		// Token: 0x06006088 RID: 24712
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSingleVTPExporter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006089 RID: 24713 RVA: 0x0008B010 File Offset: 0x00089210
		public new vtkSingleVTPExporter NewInstance()
		{
			vtkSingleVTPExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSingleVTPExporter.vtkSingleVTPExporter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSingleVTPExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600608A RID: 24714
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSingleVTPExporter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600608B RID: 24715 RVA: 0x0008B06C File Offset: 0x0008926C
		public new static vtkSingleVTPExporter SafeDownCast(vtkObjectBase o)
		{
			vtkSingleVTPExporter vtkSingleVTPExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSingleVTPExporter.vtkSingleVTPExporter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSingleVTPExporter = (vtkSingleVTPExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSingleVTPExporter.Register(null);
				}
			}
			return vtkSingleVTPExporter;
		}

		// Token: 0x0600608C RID: 24716
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSingleVTPExporter_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Specify the prefix of the files to write out. The resulting filenames
		/// will have .vtp and .png appended to them.
		/// </summary>
		// Token: 0x0600608D RID: 24717 RVA: 0x0008B0EB File Offset: 0x000892EB
		public void SetFileName(string arg0)
		{
			vtkSingleVTPExporter.vtkSingleVTPExporter_SetFileName_09(base.GetCppThis(), arg0);
		}

		// Token: 0x0600608E RID: 24718
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSingleVTPExporter_SetFilePrefix_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the prefix of the files to write out. The resulting filenames
		/// will have .vtp and .png appended to them.
		/// </summary>
		// Token: 0x0600608F RID: 24719 RVA: 0x0008B0FB File Offset: 0x000892FB
		public virtual void SetFilePrefix(string _arg)
		{
			vtkSingleVTPExporter.vtkSingleVTPExporter_SetFilePrefix_10(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008B2 RID: 2226
		public new const string MRFullTypeName = "Kitware.VTK.vtkSingleVTPExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008B3 RID: 2227
		public new static readonly string MRClassNameKey = "class vtkSingleVTPExporter";
	}
}
