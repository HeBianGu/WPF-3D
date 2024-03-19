using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPOVExporter
	/// </summary>
	/// <remarks>
	///    Export scene into povray format.
	///
	///
	/// This Exporter can be attached to a render window in order to generate
	/// scene description files for the Persistence of Vision Raytracer
	/// www.povray.org.
	///
	/// @par Thanks:
	/// Li-Ta Lo (ollie@lanl.gov) and Jim Ahrens (ahrens@lanl.gov)
	/// Los Alamos National Laboratory
	/// </remarks>
	// Token: 0x020001EE RID: 494
	public class vtkPOVExporter : vtkExporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005DD2 RID: 24018 RVA: 0x0008816F File Offset: 0x0008636F
		static vtkPOVExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPOVExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPOVExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005DD3 RID: 24019 RVA: 0x00088197 File Offset: 0x00086397
		public vtkPOVExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005DD4 RID: 24020
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOVExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DD5 RID: 24021 RVA: 0x000881A8 File Offset: 0x000863A8
		public new static vtkPOVExporter New()
		{
			vtkPOVExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOVExporter.vtkPOVExporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOVExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DD6 RID: 24022 RVA: 0x000881FC File Offset: 0x000863FC
		public vtkPOVExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPOVExporter.vtkPOVExporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005DD7 RID: 24023 RVA: 0x00088240 File Offset: 0x00086440
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005DD8 RID: 24024
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOVExporter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// The filename to save into.
		/// </summary>
		// Token: 0x06005DD9 RID: 24025 RVA: 0x0008824C File Offset: 0x0008644C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPOVExporter.vtkPOVExporter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005DDA RID: 24026
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPOVExporter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DDB RID: 24027 RVA: 0x00088288 File Offset: 0x00086488
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPOVExporter.vtkPOVExporter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06005DDC RID: 24028
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPOVExporter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DDD RID: 24029 RVA: 0x000882A8 File Offset: 0x000864A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPOVExporter.vtkPOVExporter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06005DDE RID: 24030
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPOVExporter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DDF RID: 24031 RVA: 0x000882C4 File Offset: 0x000864C4
		public override int IsA(string type)
		{
			return vtkPOVExporter.vtkPOVExporter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06005DE0 RID: 24032
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPOVExporter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DE1 RID: 24033 RVA: 0x000882E4 File Offset: 0x000864E4
		public new static int IsTypeOf(string type)
		{
			return vtkPOVExporter.vtkPOVExporter_IsTypeOf_05(type);
		}

		// Token: 0x06005DE2 RID: 24034
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOVExporter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DE3 RID: 24035 RVA: 0x00088300 File Offset: 0x00086500
		public new vtkPOVExporter NewInstance()
		{
			vtkPOVExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOVExporter.vtkPOVExporter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOVExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005DE4 RID: 24036
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOVExporter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DE5 RID: 24037 RVA: 0x0008835C File Offset: 0x0008655C
		public new static vtkPOVExporter SafeDownCast(vtkObjectBase o)
		{
			vtkPOVExporter vtkPOVExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOVExporter.vtkPOVExporter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPOVExporter = (vtkPOVExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPOVExporter.Register(null);
				}
			}
			return vtkPOVExporter;
		}

		// Token: 0x06005DE6 RID: 24038
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPOVExporter_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The filename to save into.
		/// </summary>
		// Token: 0x06005DE7 RID: 24039 RVA: 0x000883DB File Offset: 0x000865DB
		public virtual void SetFileName(string _arg)
		{
			vtkPOVExporter.vtkPOVExporter_SetFileName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008A6 RID: 2214
		public new const string MRFullTypeName = "Kitware.VTK.vtkPOVExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008A7 RID: 2215
		public new static readonly string MRClassNameKey = "class vtkPOVExporter";
	}
}
