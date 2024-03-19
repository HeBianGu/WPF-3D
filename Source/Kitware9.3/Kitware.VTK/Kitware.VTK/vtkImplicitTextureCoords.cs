using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitTextureCoords
	/// </summary>
	/// <remarks>
	///    generate 1D, 2D, or 3D texture coordinates based on implicit function(s)
	///
	/// vtkImplicitTextureCoords is a filter to generate 1D, 2D, or 3D texture
	/// coordinates from one, two, or three implicit functions, respectively.
	/// In combinations with a vtkBooleanTexture map (or another texture map of
	/// your own creation), the texture coordinates can be used to highlight
	///             (via color or intensity) or cut (via transparency) dataset geometry without
	/// any complex geometric processing. (Note: the texture coordinates are
	/// referred to as r-s-t coordinates.)
	///
	/// The texture coordinates are automatically normalized to lie between (0,1).
	/// Thus, no matter what the implicit functions evaluate to, the resulting
	/// texture coordinates lie between (0,1), with the zero implicit function
	/// value mapped to the 0.5 texture coordinates value. Depending upon the
	/// maximum negative/positive implicit function values, the full (0,1) range
	/// may not be occupied (i.e., the positive/negative ranges are mapped using
	/// the same scale factor).
	///
	/// A boolean variable InvertTexture is available to flip the texture
	/// coordinates around 0.5 (value 1.0 becomes 0.0, 0.25-&gt;0.75). This is
	/// equivalent to flipping the texture map (but a whole lot easier).
	///
	/// @warning
	/// You can use the transformation capabilities of vtkImplicitFunction to
	/// orient, translate, and scale the implicit functions. Also, the dimension of
	/// the texture coordinates is implicitly defined by the number of implicit
	/// functions defined.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitFunction vtkTexture vtkBooleanTexture vtkTransformTexture
	/// </seealso>
	// Token: 0x0200053F RID: 1343
	public class vtkImplicitTextureCoords : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EF09 RID: 61193 RVA: 0x0014D3F3 File Offset: 0x0014B5F3
		static vtkImplicitTextureCoords()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitTextureCoords.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitTextureCoords"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EF0A RID: 61194 RVA: 0x0014D41B File Offset: 0x0014B61B
		public vtkImplicitTextureCoords(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EF0B RID: 61195
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitTextureCoords_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create object with texture dimension=2 and no r-s-t implicit functions
		/// defined and FlipTexture turned off.
		/// </summary>
		// Token: 0x0600EF0C RID: 61196 RVA: 0x0014D42C File Offset: 0x0014B62C
		public new static vtkImplicitTextureCoords New()
		{
			vtkImplicitTextureCoords result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitTextureCoords.vtkImplicitTextureCoords_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitTextureCoords)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create object with texture dimension=2 and no r-s-t implicit functions
		/// defined and FlipTexture turned off.
		/// </summary>
		// Token: 0x0600EF0D RID: 61197 RVA: 0x0014D480 File Offset: 0x0014B680
		public vtkImplicitTextureCoords() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitTextureCoords.vtkImplicitTextureCoords_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EF0E RID: 61198 RVA: 0x0014D4C4 File Offset: 0x0014B6C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EF0F RID: 61199
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitTextureCoords_FlipTextureOff_01(HandleRef pThis);

		/// <summary>
		/// If enabled, this will flip the sense of inside and outside the implicit
		/// function (i.e., a rotation around the r-s-t=0.5 axis).
		/// </summary>
		// Token: 0x0600EF10 RID: 61200 RVA: 0x0014D4CF File Offset: 0x0014B6CF
		public virtual void FlipTextureOff()
		{
			vtkImplicitTextureCoords.vtkImplicitTextureCoords_FlipTextureOff_01(base.GetCppThis());
		}

		// Token: 0x0600EF11 RID: 61201
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitTextureCoords_FlipTextureOn_02(HandleRef pThis);

		/// <summary>
		/// If enabled, this will flip the sense of inside and outside the implicit
		/// function (i.e., a rotation around the r-s-t=0.5 axis).
		/// </summary>
		// Token: 0x0600EF12 RID: 61202 RVA: 0x0014D4DE File Offset: 0x0014B6DE
		public virtual void FlipTextureOn()
		{
			vtkImplicitTextureCoords.vtkImplicitTextureCoords_FlipTextureOn_02(base.GetCppThis());
		}

		// Token: 0x0600EF13 RID: 61203
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitTextureCoords_GetFlipTexture_03(HandleRef pThis);

		/// <summary>
		/// If enabled, this will flip the sense of inside and outside the implicit
		/// function (i.e., a rotation around the r-s-t=0.5 axis).
		/// </summary>
		// Token: 0x0600EF14 RID: 61204 RVA: 0x0014D4F0 File Offset: 0x0014B6F0
		public virtual int GetFlipTexture()
		{
			return vtkImplicitTextureCoords.vtkImplicitTextureCoords_GetFlipTexture_03(base.GetCppThis());
		}

		// Token: 0x0600EF15 RID: 61205
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitTextureCoords_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF16 RID: 61206 RVA: 0x0014D510 File Offset: 0x0014B710
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitTextureCoords.vtkImplicitTextureCoords_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600EF17 RID: 61207
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitTextureCoords_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF18 RID: 61208 RVA: 0x0014D530 File Offset: 0x0014B730
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitTextureCoords.vtkImplicitTextureCoords_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600EF19 RID: 61209
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitTextureCoords_GetRFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify an implicit function to compute the r texture coordinate.
		/// </summary>
		// Token: 0x0600EF1A RID: 61210 RVA: 0x0014D54C File Offset: 0x0014B74C
		public virtual vtkImplicitFunction GetRFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitTextureCoords.vtkImplicitTextureCoords_GetRFunction_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x0600EF1B RID: 61211
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitTextureCoords_GetSFunction_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify an implicit function to compute the s texture coordinate.
		/// </summary>
		// Token: 0x0600EF1C RID: 61212 RVA: 0x0014D5BC File Offset: 0x0014B7BC
		public virtual vtkImplicitFunction GetSFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitTextureCoords.vtkImplicitTextureCoords_GetSFunction_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x0600EF1D RID: 61213
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitTextureCoords_GetTFunction_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify an implicit function to compute the t texture coordinate.
		/// </summary>
		// Token: 0x0600EF1E RID: 61214 RVA: 0x0014D62C File Offset: 0x0014B82C
		public virtual vtkImplicitFunction GetTFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitTextureCoords.vtkImplicitTextureCoords_GetTFunction_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x0600EF1F RID: 61215
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitTextureCoords_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF20 RID: 61216 RVA: 0x0014D69C File Offset: 0x0014B89C
		public override int IsA(string type)
		{
			return vtkImplicitTextureCoords.vtkImplicitTextureCoords_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600EF21 RID: 61217
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitTextureCoords_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF22 RID: 61218 RVA: 0x0014D6BC File Offset: 0x0014B8BC
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitTextureCoords.vtkImplicitTextureCoords_IsTypeOf_10(type);
		}

		// Token: 0x0600EF23 RID: 61219
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitTextureCoords_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF24 RID: 61220 RVA: 0x0014D6D8 File Offset: 0x0014B8D8
		public new vtkImplicitTextureCoords NewInstance()
		{
			vtkImplicitTextureCoords result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitTextureCoords.vtkImplicitTextureCoords_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitTextureCoords)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EF25 RID: 61221
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitTextureCoords_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF26 RID: 61222 RVA: 0x0014D734 File Offset: 0x0014B934
		public new static vtkImplicitTextureCoords SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitTextureCoords vtkImplicitTextureCoords = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitTextureCoords.vtkImplicitTextureCoords_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitTextureCoords = (vtkImplicitTextureCoords)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitTextureCoords.Register(null);
				}
			}
			return vtkImplicitTextureCoords;
		}

		// Token: 0x0600EF27 RID: 61223
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitTextureCoords_SetFlipTexture_14(HandleRef pThis, int _arg);

		/// <summary>
		/// If enabled, this will flip the sense of inside and outside the implicit
		/// function (i.e., a rotation around the r-s-t=0.5 axis).
		/// </summary>
		// Token: 0x0600EF28 RID: 61224 RVA: 0x0014D7B3 File Offset: 0x0014B9B3
		public virtual void SetFlipTexture(int _arg)
		{
			vtkImplicitTextureCoords.vtkImplicitTextureCoords_SetFlipTexture_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EF29 RID: 61225
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitTextureCoords_SetRFunction_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify an implicit function to compute the r texture coordinate.
		/// </summary>
		// Token: 0x0600EF2A RID: 61226 RVA: 0x0014D7C4 File Offset: 0x0014B9C4
		public virtual void SetRFunction(vtkImplicitFunction arg0)
		{
			vtkImplicitTextureCoords.vtkImplicitTextureCoords_SetRFunction_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600EF2B RID: 61227
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitTextureCoords_SetSFunction_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify an implicit function to compute the s texture coordinate.
		/// </summary>
		// Token: 0x0600EF2C RID: 61228 RVA: 0x0014D7F4 File Offset: 0x0014B9F4
		public virtual void SetSFunction(vtkImplicitFunction arg0)
		{
			vtkImplicitTextureCoords.vtkImplicitTextureCoords_SetSFunction_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600EF2D RID: 61229
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitTextureCoords_SetTFunction_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify an implicit function to compute the t texture coordinate.
		/// </summary>
		// Token: 0x0600EF2E RID: 61230 RVA: 0x0014D824 File Offset: 0x0014BA24
		public virtual void SetTFunction(vtkImplicitFunction arg0)
		{
			vtkImplicitTextureCoords.vtkImplicitTextureCoords_SetTFunction_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001176 RID: 4470
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitTextureCoords";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001177 RID: 4471
		public new static readonly string MRClassNameKey = "class vtkImplicitTextureCoords";
	}
}
