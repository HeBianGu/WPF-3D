using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRMLExporter
	/// </summary>
	/// <remarks>
	///    export a scene into VRML 2.0 format.
	///
	/// vtkVRMLExporter is a concrete subclass of vtkExporter that writes VRML 2.0
	/// files. This is based on the VRML 2.0 draft #3 but it should be pretty
	/// stable since we aren't using any of the newer features.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExporter
	/// </seealso>
	// Token: 0x020001F5 RID: 501
	public class vtkVRMLExporter : vtkExporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006090 RID: 24720 RVA: 0x0008B10B File Offset: 0x0008930B
		static vtkVRMLExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRMLExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRMLExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006091 RID: 24721 RVA: 0x0008B133 File Offset: 0x00089333
		public vtkVRMLExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006092 RID: 24722
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMLExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006093 RID: 24723 RVA: 0x0008B144 File Offset: 0x00089344
		public new static vtkVRMLExporter New()
		{
			vtkVRMLExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRMLExporter.vtkVRMLExporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRMLExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006094 RID: 24724 RVA: 0x0008B198 File Offset: 0x00089398
		public vtkVRMLExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVRMLExporter.vtkVRMLExporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006095 RID: 24725 RVA: 0x0008B1DC File Offset: 0x000893DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006096 RID: 24726
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMLExporter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Specify the name of the VRML file to write.
		/// </summary>
		// Token: 0x06006097 RID: 24727 RVA: 0x0008B1E8 File Offset: 0x000893E8
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkVRMLExporter.vtkVRMLExporter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006098 RID: 24728
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRMLExporter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006099 RID: 24729 RVA: 0x0008B224 File Offset: 0x00089424
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRMLExporter.vtkVRMLExporter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600609A RID: 24730
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRMLExporter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600609B RID: 24731 RVA: 0x0008B244 File Offset: 0x00089444
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRMLExporter.vtkVRMLExporter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600609C RID: 24732
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVRMLExporter_GetSpeed_04(HandleRef pThis);

		/// <summary>
		/// Specify the Speed of navigation. Default is 4.
		/// </summary>
		// Token: 0x0600609D RID: 24733 RVA: 0x0008B260 File Offset: 0x00089460
		public virtual double GetSpeed()
		{
			return vtkVRMLExporter.vtkVRMLExporter_GetSpeed_04(base.GetCppThis());
		}

		// Token: 0x0600609E RID: 24734
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRMLExporter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600609F RID: 24735 RVA: 0x0008B280 File Offset: 0x00089480
		public override int IsA(string type)
		{
			return vtkVRMLExporter.vtkVRMLExporter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060060A0 RID: 24736
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRMLExporter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060060A1 RID: 24737 RVA: 0x0008B2A0 File Offset: 0x000894A0
		public new static int IsTypeOf(string type)
		{
			return vtkVRMLExporter.vtkVRMLExporter_IsTypeOf_06(type);
		}

		// Token: 0x060060A2 RID: 24738
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMLExporter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060060A3 RID: 24739 RVA: 0x0008B2BC File Offset: 0x000894BC
		public new vtkVRMLExporter NewInstance()
		{
			vtkVRMLExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRMLExporter.vtkVRMLExporter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRMLExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060060A4 RID: 24740
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMLExporter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060060A5 RID: 24741 RVA: 0x0008B318 File Offset: 0x00089518
		public new static vtkVRMLExporter SafeDownCast(vtkObjectBase o)
		{
			vtkVRMLExporter vtkVRMLExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRMLExporter.vtkVRMLExporter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRMLExporter = (vtkVRMLExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRMLExporter.Register(null);
				}
			}
			return vtkVRMLExporter;
		}

		// Token: 0x060060A6 RID: 24742
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMLExporter_SetFileName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the VRML file to write.
		/// </summary>
		// Token: 0x060060A7 RID: 24743 RVA: 0x0008B397 File Offset: 0x00089597
		public virtual void SetFileName(string _arg)
		{
			vtkVRMLExporter.vtkVRMLExporter_SetFileName_10(base.GetCppThis(), _arg);
		}

		// Token: 0x060060A8 RID: 24744
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMLExporter_SetSpeed_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the Speed of navigation. Default is 4.
		/// </summary>
		// Token: 0x060060A9 RID: 24745 RVA: 0x0008B3A7 File Offset: 0x000895A7
		public virtual void SetSpeed(double _arg)
		{
			vtkVRMLExporter.vtkVRMLExporter_SetSpeed_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008B4 RID: 2228
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRMLExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008B5 RID: 2229
		public new static readonly string MRClassNameKey = "class vtkVRMLExporter";
	}
}
