using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataSetGradient
	/// </summary>
	/// <remarks>
	///    computes scalar field gradient
	///
	///
	/// vtkDataSetGradient Computes per cell gradient of point scalar field
	/// or per point gradient of cell scalar field.
	///
	/// @par Thanks:
	/// This file is part of the generalized Youngs material interface reconstruction algorithm
	/// contributed by CEA/DIF - Commissariat a l'Energie Atomique, Centre DAM Ile-De-France &lt;br&gt; BP12,
	/// F-91297 Arpajon, France. &lt;br&gt; Implementation by Thierry Carrard (CEA)
	/// </remarks>
	// Token: 0x0200088C RID: 2188
	public class vtkDataSetGradient : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016BCA RID: 93130 RVA: 0x001FF71F File Offset: 0x001FD91F
		static vtkDataSetGradient()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetGradient.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetGradient"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016BCB RID: 93131 RVA: 0x001FF747 File Offset: 0x001FD947
		public vtkDataSetGradient(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016BCC RID: 93132
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetGradient_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BCD RID: 93133 RVA: 0x001FF758 File Offset: 0x001FD958
		public new static vtkDataSetGradient New()
		{
			vtkDataSetGradient result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetGradient.vtkDataSetGradient_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetGradient)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BCE RID: 93134 RVA: 0x001FF7AC File Offset: 0x001FD9AC
		public vtkDataSetGradient() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataSetGradient.vtkDataSetGradient_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016BCF RID: 93135 RVA: 0x001FF7F0 File Offset: 0x001FD9F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016BD0 RID: 93136
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetGradient_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BD1 RID: 93137 RVA: 0x001FF7FC File Offset: 0x001FD9FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataSetGradient.vtkDataSetGradient_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016BD2 RID: 93138
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetGradient_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BD3 RID: 93139 RVA: 0x001FF81C File Offset: 0x001FDA1C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataSetGradient.vtkDataSetGradient_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016BD4 RID: 93140
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetGradient_GetResultArrayName_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of computed vector array.
		/// </summary>
		// Token: 0x06016BD5 RID: 93141 RVA: 0x001FF838 File Offset: 0x001FDA38
		public virtual string GetResultArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataSetGradient.vtkDataSetGradient_GetResultArrayName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016BD6 RID: 93142
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetGradient_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BD7 RID: 93143 RVA: 0x001FF874 File Offset: 0x001FDA74
		public override int IsA(string type)
		{
			return vtkDataSetGradient.vtkDataSetGradient_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06016BD8 RID: 93144
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetGradient_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BD9 RID: 93145 RVA: 0x001FF894 File Offset: 0x001FDA94
		public new static int IsTypeOf(string type)
		{
			return vtkDataSetGradient.vtkDataSetGradient_IsTypeOf_05(type);
		}

		// Token: 0x06016BDA RID: 93146
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetGradient_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BDB RID: 93147 RVA: 0x001FF8B0 File Offset: 0x001FDAB0
		public new vtkDataSetGradient NewInstance()
		{
			vtkDataSetGradient result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetGradient.vtkDataSetGradient_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetGradient)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016BDC RID: 93148
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetGradient_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BDD RID: 93149 RVA: 0x001FF90C File Offset: 0x001FDB0C
		public new static vtkDataSetGradient SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetGradient vtkDataSetGradient = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetGradient.vtkDataSetGradient_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetGradient = (vtkDataSetGradient)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetGradient.Register(null);
				}
			}
			return vtkDataSetGradient;
		}

		// Token: 0x06016BDE RID: 93150
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetGradient_SetResultArrayName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of computed vector array.
		/// </summary>
		// Token: 0x06016BDF RID: 93151 RVA: 0x001FF98B File Offset: 0x001FDB8B
		public virtual void SetResultArrayName(string _arg)
		{
			vtkDataSetGradient.vtkDataSetGradient_SetResultArrayName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001979 RID: 6521
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetGradient";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400197A RID: 6522
		public new static readonly string MRClassNameKey = "class vtkDataSetGradient";
	}
}
