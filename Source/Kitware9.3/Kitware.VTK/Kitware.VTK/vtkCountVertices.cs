using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCountVertices
	/// </summary>
	/// <remarks>
	///    Add a cell data array containing the number of
	/// vertices per cell.
	///
	///
	/// This filter adds a cell data array containing the number of vertices per
	/// cell.
	/// </remarks>
	// Token: 0x02000888 RID: 2184
	public class vtkCountVertices : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016AD8 RID: 92888 RVA: 0x001FE6A7 File Offset: 0x001FC8A7
		static vtkCountVertices()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCountVertices.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCountVertices"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016AD9 RID: 92889 RVA: 0x001FE6CF File Offset: 0x001FC8CF
		public vtkCountVertices(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016ADA RID: 92890
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCountVertices_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016ADB RID: 92891 RVA: 0x001FE6E0 File Offset: 0x001FC8E0
		public new static vtkCountVertices New()
		{
			vtkCountVertices result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCountVertices.vtkCountVertices_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCountVertices)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016ADC RID: 92892 RVA: 0x001FE734 File Offset: 0x001FC934
		public vtkCountVertices() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCountVertices.vtkCountVertices_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016ADD RID: 92893 RVA: 0x001FE778 File Offset: 0x001FC978
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016ADE RID: 92894
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCountVertices_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016ADF RID: 92895 RVA: 0x001FE784 File Offset: 0x001FC984
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCountVertices.vtkCountVertices_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016AE0 RID: 92896
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCountVertices_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016AE1 RID: 92897 RVA: 0x001FE7A4 File Offset: 0x001FC9A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCountVertices.vtkCountVertices_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016AE2 RID: 92898
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCountVertices_GetOutputArrayName_03(HandleRef pThis);

		/// <summary>
		/// The name of the new output array containing the vertex counts.
		/// </summary>
		// Token: 0x06016AE3 RID: 92899 RVA: 0x001FE7C0 File Offset: 0x001FC9C0
		public virtual string GetOutputArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCountVertices.vtkCountVertices_GetOutputArrayName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016AE4 RID: 92900
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCountVertices_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016AE5 RID: 92901 RVA: 0x001FE7FC File Offset: 0x001FC9FC
		public override int IsA(string type)
		{
			return vtkCountVertices.vtkCountVertices_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06016AE6 RID: 92902
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCountVertices_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016AE7 RID: 92903 RVA: 0x001FE81C File Offset: 0x001FCA1C
		public new static int IsTypeOf(string type)
		{
			return vtkCountVertices.vtkCountVertices_IsTypeOf_05(type);
		}

		// Token: 0x06016AE8 RID: 92904
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCountVertices_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016AE9 RID: 92905 RVA: 0x001FE838 File Offset: 0x001FCA38
		public new vtkCountVertices NewInstance()
		{
			vtkCountVertices result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCountVertices.vtkCountVertices_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCountVertices)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016AEA RID: 92906
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCountVertices_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016AEB RID: 92907 RVA: 0x001FE894 File Offset: 0x001FCA94
		public new static vtkCountVertices SafeDownCast(vtkObjectBase o)
		{
			vtkCountVertices vtkCountVertices = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCountVertices.vtkCountVertices_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCountVertices = (vtkCountVertices)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCountVertices.Register(null);
				}
			}
			return vtkCountVertices;
		}

		// Token: 0x06016AEC RID: 92908
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCountVertices_SetOutputArrayName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the new output array containing the vertex counts.
		/// </summary>
		// Token: 0x06016AED RID: 92909 RVA: 0x001FE913 File Offset: 0x001FCB13
		public virtual void SetOutputArrayName(string _arg)
		{
			vtkCountVertices.vtkCountVertices_SetOutputArrayName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001971 RID: 6513
		public new const string MRFullTypeName = "Kitware.VTK.vtkCountVertices";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001972 RID: 6514
		public new static readonly string MRClassNameKey = "class vtkCountVertices";
	}
}
