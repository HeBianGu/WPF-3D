using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataSetGradientPrecompute
	///
	///
	/// Computes a geometry based vector field that the DataSetGradient filter uses to accelerate
	/// gradient computation. This vector field is added to FieldData since it has a different
	/// value for each vertex of each cell (a vertex shared by two cell has two different values).
	///
	/// @par Thanks:
	/// This file is part of the generalized Youngs material interface reconstruction algorithm
	/// contributed by CEA/DIF - Commissariat a l'Energie Atomique, Centre DAM Ile-De-France &lt;br&gt; BP12,
	/// F-91297 Arpajon, France. &lt;br&gt; Implementation by Thierry Carrard (CEA)
	/// </summary>
	// Token: 0x0200088D RID: 2189
	public class vtkDataSetGradientPrecompute : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016BE0 RID: 93152 RVA: 0x001FF99B File Offset: 0x001FDB9B
		static vtkDataSetGradientPrecompute()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetGradientPrecompute.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetGradientPrecompute"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016BE1 RID: 93153 RVA: 0x001FF9C3 File Offset: 0x001FDBC3
		public vtkDataSetGradientPrecompute(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016BE2 RID: 93154
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetGradientPrecompute_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BE3 RID: 93155 RVA: 0x001FF9D4 File Offset: 0x001FDBD4
		public new static vtkDataSetGradientPrecompute New()
		{
			vtkDataSetGradientPrecompute result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetGradientPrecompute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BE4 RID: 93156 RVA: 0x001FFA28 File Offset: 0x001FDC28
		public vtkDataSetGradientPrecompute() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016BE5 RID: 93157 RVA: 0x001FFA6C File Offset: 0x001FDC6C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016BE6 RID: 93158
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetGradientPrecompute_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BE7 RID: 93159 RVA: 0x001FFA78 File Offset: 0x001FDC78
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016BE8 RID: 93160
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetGradientPrecompute_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BE9 RID: 93161 RVA: 0x001FFA98 File Offset: 0x001FDC98
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016BEA RID: 93162
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetGradientPrecompute_GradientPrecompute_03(HandleRef ds, HandleRef self);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BEB RID: 93163 RVA: 0x001FFAB4 File Offset: 0x001FDCB4
		public static int GradientPrecompute(vtkDataSet ds, vtkDataSetAlgorithm self)
		{
			return vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_GradientPrecompute_03((ds == null) ? default(HandleRef) : ds.GetCppThis(), (self == null) ? default(HandleRef) : self.GetCppThis());
		}

		// Token: 0x06016BEC RID: 93164
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetGradientPrecompute_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BED RID: 93165 RVA: 0x001FFAF8 File Offset: 0x001FDCF8
		public override int IsA(string type)
		{
			return vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06016BEE RID: 93166
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetGradientPrecompute_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BEF RID: 93167 RVA: 0x001FFB18 File Offset: 0x001FDD18
		public new static int IsTypeOf(string type)
		{
			return vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_IsTypeOf_05(type);
		}

		// Token: 0x06016BF0 RID: 93168
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetGradientPrecompute_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BF1 RID: 93169 RVA: 0x001FFB34 File Offset: 0x001FDD34
		public new vtkDataSetGradientPrecompute NewInstance()
		{
			vtkDataSetGradientPrecompute result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetGradientPrecompute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016BF2 RID: 93170
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetGradientPrecompute_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BF3 RID: 93171 RVA: 0x001FFB90 File Offset: 0x001FDD90
		public new static vtkDataSetGradientPrecompute SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetGradientPrecompute vtkDataSetGradientPrecompute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetGradientPrecompute = (vtkDataSetGradientPrecompute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetGradientPrecompute.Register(null);
				}
			}
			return vtkDataSetGradientPrecompute;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400197B RID: 6523
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetGradientPrecompute";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400197C RID: 6524
		public new static readonly string MRClassNameKey = "class vtkDataSetGradientPrecompute";
	}
}
