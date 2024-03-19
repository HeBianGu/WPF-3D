using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWarpTo
	/// </summary>
	/// <remarks>
	///    deform geometry by warping towards a point
	///
	/// vtkWarpTo is a filter that modifies point coordinates by moving the
	/// points towards a user specified position.
	/// </remarks>
	// Token: 0x020008FB RID: 2299
	public class vtkWarpTo : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017BF3 RID: 97267 RVA: 0x00214B55 File Offset: 0x00212D55
		static vtkWarpTo()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWarpTo.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpTo"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017BF4 RID: 97268 RVA: 0x00214B7D File Offset: 0x00212D7D
		public vtkWarpTo(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017BF5 RID: 97269
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpTo_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017BF6 RID: 97270 RVA: 0x00214B8C File Offset: 0x00212D8C
		public new static vtkWarpTo New()
		{
			vtkWarpTo result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWarpTo.vtkWarpTo_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpTo)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017BF7 RID: 97271 RVA: 0x00214BE0 File Offset: 0x00212DE0
		public vtkWarpTo() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWarpTo.vtkWarpTo_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017BF8 RID: 97272 RVA: 0x00214C24 File Offset: 0x00212E24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017BF9 RID: 97273
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpTo_AbsoluteOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the Absolute ivar. Turning Absolute on causes scale factor
		/// of the new position to be one unit away from Position.
		/// </summary>
		// Token: 0x06017BFA RID: 97274 RVA: 0x00214C2F File Offset: 0x00212E2F
		public virtual void AbsoluteOff()
		{
			vtkWarpTo.vtkWarpTo_AbsoluteOff_01(base.GetCppThis());
		}

		// Token: 0x06017BFB RID: 97275
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpTo_AbsoluteOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the Absolute ivar. Turning Absolute on causes scale factor
		/// of the new position to be one unit away from Position.
		/// </summary>
		// Token: 0x06017BFC RID: 97276 RVA: 0x00214C3E File Offset: 0x00212E3E
		public virtual void AbsoluteOn()
		{
			vtkWarpTo.vtkWarpTo_AbsoluteOn_02(base.GetCppThis());
		}

		// Token: 0x06017BFD RID: 97277
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpTo_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Set/Get the Absolute ivar. Turning Absolute on causes scale factor
		/// of the new position to be one unit away from Position.
		/// </summary>
		// Token: 0x06017BFE RID: 97278 RVA: 0x00214C50 File Offset: 0x00212E50
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkWarpTo.vtkWarpTo_FillInputPortInformation_03(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x06017BFF RID: 97279
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpTo_GetAbsolute_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the Absolute ivar. Turning Absolute on causes scale factor
		/// of the new position to be one unit away from Position.
		/// </summary>
		// Token: 0x06017C00 RID: 97280 RVA: 0x00214C88 File Offset: 0x00212E88
		public virtual int GetAbsolute()
		{
			return vtkWarpTo.vtkWarpTo_GetAbsolute_04(base.GetCppThis());
		}

		// Token: 0x06017C01 RID: 97281
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWarpTo_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C02 RID: 97282 RVA: 0x00214CA8 File Offset: 0x00212EA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWarpTo.vtkWarpTo_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06017C03 RID: 97283
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWarpTo_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C04 RID: 97284 RVA: 0x00214CC8 File Offset: 0x00212EC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWarpTo.vtkWarpTo_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06017C05 RID: 97285
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpTo_GetPosition_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the position to warp towards.
		/// </summary>
		// Token: 0x06017C06 RID: 97286 RVA: 0x00214CE4 File Offset: 0x00212EE4
		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkWarpTo.vtkWarpTo_GetPosition_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06017C07 RID: 97287
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpTo_GetPosition_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the position to warp towards.
		/// </summary>
		// Token: 0x06017C08 RID: 97288 RVA: 0x00214D2C File Offset: 0x00212F2C
		public virtual void GetPosition(IntPtr data)
		{
			vtkWarpTo.vtkWarpTo_GetPosition_08(base.GetCppThis(), data);
		}

		// Token: 0x06017C09 RID: 97289
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWarpTo_GetScaleFactor_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the value to scale displacement.
		/// </summary>
		// Token: 0x06017C0A RID: 97290 RVA: 0x00214D3C File Offset: 0x00212F3C
		public virtual double GetScaleFactor()
		{
			return vtkWarpTo.vtkWarpTo_GetScaleFactor_09(base.GetCppThis());
		}

		// Token: 0x06017C0B RID: 97291
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpTo_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C0C RID: 97292 RVA: 0x00214D5C File Offset: 0x00212F5C
		public override int IsA(string type)
		{
			return vtkWarpTo.vtkWarpTo_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06017C0D RID: 97293
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpTo_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C0E RID: 97294 RVA: 0x00214D7C File Offset: 0x00212F7C
		public new static int IsTypeOf(string type)
		{
			return vtkWarpTo.vtkWarpTo_IsTypeOf_11(type);
		}

		// Token: 0x06017C0F RID: 97295
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpTo_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C10 RID: 97296 RVA: 0x00214D98 File Offset: 0x00212F98
		public new vtkWarpTo NewInstance()
		{
			vtkWarpTo result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWarpTo.vtkWarpTo_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpTo)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017C11 RID: 97297
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpTo_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C12 RID: 97298 RVA: 0x00214DF4 File Offset: 0x00212FF4
		public new static vtkWarpTo SafeDownCast(vtkObjectBase o)
		{
			vtkWarpTo vtkWarpTo = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWarpTo.vtkWarpTo_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWarpTo = (vtkWarpTo)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWarpTo.Register(null);
				}
			}
			return vtkWarpTo;
		}

		// Token: 0x06017C13 RID: 97299
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpTo_SetAbsolute_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the Absolute ivar. Turning Absolute on causes scale factor
		/// of the new position to be one unit away from Position.
		/// </summary>
		// Token: 0x06017C14 RID: 97300 RVA: 0x00214E73 File Offset: 0x00213073
		public virtual void SetAbsolute(int _arg)
		{
			vtkWarpTo.vtkWarpTo_SetAbsolute_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06017C15 RID: 97301
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpTo_SetPosition_16(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the position to warp towards.
		/// </summary>
		// Token: 0x06017C16 RID: 97302 RVA: 0x00214E83 File Offset: 0x00213083
		public virtual void SetPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkWarpTo.vtkWarpTo_SetPosition_16(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06017C17 RID: 97303
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpTo_SetPosition_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the position to warp towards.
		/// </summary>
		// Token: 0x06017C18 RID: 97304 RVA: 0x00214E95 File Offset: 0x00213095
		public virtual void SetPosition(IntPtr _arg)
		{
			vtkWarpTo.vtkWarpTo_SetPosition_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06017C19 RID: 97305
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpTo_SetScaleFactor_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the value to scale displacement.
		/// </summary>
		// Token: 0x06017C1A RID: 97306 RVA: 0x00214EA5 File Offset: 0x002130A5
		public virtual void SetScaleFactor(double _arg)
		{
			vtkWarpTo.vtkWarpTo_SetScaleFactor_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A75 RID: 6773
		public new const string MRFullTypeName = "Kitware.VTK.vtkWarpTo";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A76 RID: 6774
		public new static readonly string MRClassNameKey = "class vtkWarpTo";
	}
}
