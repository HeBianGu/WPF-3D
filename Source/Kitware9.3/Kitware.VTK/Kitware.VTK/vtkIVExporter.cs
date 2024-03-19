using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIVExporter
	/// </summary>
	/// <remarks>
	///    export a scene into OpenInventor 2.0 format.
	///
	/// vtkIVExporter is a concrete subclass of vtkExporter that writes
	/// OpenInventor 2.0 files.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExporter
	/// </seealso>
	// Token: 0x020001E8 RID: 488
	public class vtkIVExporter : vtkExporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005D08 RID: 23816 RVA: 0x00086C4B File Offset: 0x00084E4B
		static vtkIVExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIVExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIVExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005D09 RID: 23817 RVA: 0x00086C73 File Offset: 0x00084E73
		public vtkIVExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005D0A RID: 23818
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIVExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D0B RID: 23819 RVA: 0x00086C84 File Offset: 0x00084E84
		public new static vtkIVExporter New()
		{
			vtkIVExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIVExporter.vtkIVExporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIVExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D0C RID: 23820 RVA: 0x00086CD8 File Offset: 0x00084ED8
		public vtkIVExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIVExporter.vtkIVExporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005D0D RID: 23821 RVA: 0x00086D1C File Offset: 0x00084F1C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005D0E RID: 23822
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIVExporter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Specify the name of the OpenInventor file to write.
		/// </summary>
		// Token: 0x06005D0F RID: 23823 RVA: 0x00086D28 File Offset: 0x00084F28
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkIVExporter.vtkIVExporter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005D10 RID: 23824
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIVExporter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D11 RID: 23825 RVA: 0x00086D64 File Offset: 0x00084F64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIVExporter.vtkIVExporter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06005D12 RID: 23826
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIVExporter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D13 RID: 23827 RVA: 0x00086D84 File Offset: 0x00084F84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIVExporter.vtkIVExporter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06005D14 RID: 23828
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIVExporter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D15 RID: 23829 RVA: 0x00086DA0 File Offset: 0x00084FA0
		public override int IsA(string type)
		{
			return vtkIVExporter.vtkIVExporter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06005D16 RID: 23830
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIVExporter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D17 RID: 23831 RVA: 0x00086DC0 File Offset: 0x00084FC0
		public new static int IsTypeOf(string type)
		{
			return vtkIVExporter.vtkIVExporter_IsTypeOf_05(type);
		}

		// Token: 0x06005D18 RID: 23832
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIVExporter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D19 RID: 23833 RVA: 0x00086DDC File Offset: 0x00084FDC
		public new vtkIVExporter NewInstance()
		{
			vtkIVExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIVExporter.vtkIVExporter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIVExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005D1A RID: 23834
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIVExporter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D1B RID: 23835 RVA: 0x00086E38 File Offset: 0x00085038
		public new static vtkIVExporter SafeDownCast(vtkObjectBase o)
		{
			vtkIVExporter vtkIVExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIVExporter.vtkIVExporter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIVExporter = (vtkIVExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIVExporter.Register(null);
				}
			}
			return vtkIVExporter;
		}

		// Token: 0x06005D1C RID: 23836
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIVExporter_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the OpenInventor file to write.
		/// </summary>
		// Token: 0x06005D1D RID: 23837 RVA: 0x00086EB7 File Offset: 0x000850B7
		public virtual void SetFileName(string _arg)
		{
			vtkIVExporter.vtkIVExporter_SetFileName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400089A RID: 2202
		public new const string MRFullTypeName = "Kitware.VTK.vtkIVExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400089B RID: 2203
		public new static readonly string MRClassNameKey = "class vtkIVExporter";
	}
}
